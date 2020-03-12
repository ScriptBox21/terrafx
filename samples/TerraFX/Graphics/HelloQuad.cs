// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using TerraFX.ApplicationModel;
using TerraFX.Graphics;
using TerraFX.Numerics;
using TerraFX.UI;
using TerraFX.Utilities;

namespace TerraFX.Samples.Graphics
{
    public sealed class HelloQuad : Sample
    {
        private GraphicsDevice _graphicsDevice = null!;
        private GraphicsPrimitive _quadPrimitive = null!;
        private Window _window = null!;
        private TimeSpan _elapsedTime;

        public HelloQuad(string name, params Assembly[] compositionAssemblies)
            : base(name, compositionAssemblies)
        {
        }

        public override void Cleanup()
        {
            _quadPrimitive?.Dispose();
            _graphicsDevice?.Dispose();
            _window?.Dispose();

            base.Cleanup();
        }

        public override void Initialize(Application application)
        {
            ExceptionUtilities.ThrowIfNull(application, nameof(application));

            var windowProvider = application.GetService<WindowProvider>();
            _window = windowProvider.CreateWindow();
            _window.Show();

            var graphicsProvider = application.GetService<GraphicsProvider>();
            var graphicsAdapter = graphicsProvider.GraphicsAdapters.First();

            _graphicsDevice = graphicsAdapter.CreateGraphicsDevice(_window, graphicsContextCount: 2);
            _quadPrimitive = CreateQuadPrimitive();
            
            base.Initialize(application);
        }

        protected override void OnIdle(object? sender, ApplicationIdleEventArgs eventArgs)
        {
            ExceptionUtilities.ThrowIfNull(sender, nameof(sender));

            _elapsedTime += eventArgs.Delta;

            if (_elapsedTime.TotalSeconds >= 2.5)
            {
                var application = (Application)sender;
                application.RequestExit();
            }

            if (_window.IsVisible)
            {
                var graphicsDevice = _graphicsDevice;
                var graphicsContext = graphicsDevice.GraphicsContexts[graphicsDevice.GraphicsContextIndex];

                var backgroundColor = new ColorRgba(red: 100.0f / 255.0f, green: 149.0f / 255.0f, blue: 237.0f / 255.0f, alpha: 1.0f);
                graphicsContext.BeginFrame(backgroundColor);

                graphicsContext.Draw(_quadPrimitive);

                graphicsContext.EndFrame();
                graphicsDevice.PresentFrame();
            }
        }

        private unsafe GraphicsPrimitive CreateQuadPrimitive()
        {
            var graphicsDevice = _graphicsDevice;
            var graphicsSurface = graphicsDevice.GraphicsSurface;

            var graphicsPipeline = CreateGraphicsPipeline(graphicsDevice, "Identity", "main", "main");

            var vertexBuffer = CreateVertexBuffer(graphicsDevice, aspectRatio: graphicsSurface.Width / graphicsSurface.Height);
            var indexBuffer = CreateIndexBuffer(graphicsDevice);

            return graphicsDevice.CreateGraphicsPrimitive(graphicsPipeline, vertexBuffer, indexBuffer);

            static GraphicsBuffer CreateVertexBuffer(GraphicsDevice graphicsDevice, float aspectRatio)
            {
                var vertexBuffer = graphicsDevice.CreateGraphicsBuffer(GraphicsBufferKind.Vertex, (ulong)(sizeof(IdentityVertex) * 4), (ulong)sizeof(IdentityVertex));
                var pVertexBuffer = vertexBuffer.Map<IdentityVertex>();

                pVertexBuffer[0] = new IdentityVertex {
                    Position = new Vector3(0.25f, 0.25f * aspectRatio, 0.0f),
                    Color = new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
                };

                pVertexBuffer[1] = new IdentityVertex {
                    Position = new Vector3(0.25f, -0.25f * aspectRatio, 0.0f),
                    Color = new Vector4(0.0f, 1.0f, 0.0f, 1.0f),
                };

                pVertexBuffer[2] = new IdentityVertex {
                    Position = new Vector3(-0.25f, -0.25f * aspectRatio, 0.0f),
                    Color = new Vector4(0.0f, 0.0f, 1.0f, 1.0f),
                };

                pVertexBuffer[3] = new IdentityVertex {
                    Position = new Vector3(-0.25f, 0.25f * aspectRatio, 0.0f),
                    Color = new Vector4(0.0f, 1.0f, 0.0f, 1.0f),
                };

                vertexBuffer.Unmap(0..(sizeof(IdentityVertex) * 4));
                return vertexBuffer;
            }

            static GraphicsBuffer CreateIndexBuffer(GraphicsDevice graphicsDevice)
            {
                var indexBuffer = graphicsDevice.CreateGraphicsBuffer(GraphicsBufferKind.Index, sizeof(ushort) * 6, sizeof(ushort));
                var pIndexBuffer = indexBuffer.Map<ushort>();

                pIndexBuffer[0] = 0;
                pIndexBuffer[1] = 1;
                pIndexBuffer[2] = 2;

                pIndexBuffer[3] = 0;
                pIndexBuffer[4] = 2;
                pIndexBuffer[5] = 3;

                indexBuffer.Unmap(0..(sizeof(ushort) * 6));
                return indexBuffer;
            }

            GraphicsPipeline CreateGraphicsPipeline(GraphicsDevice graphicsDevice, string shaderName, string vertexShaderEntryPoint, string pixelShaderEntryPoint)
            {
                var signature = CreateGraphicsPipelineSignature(graphicsDevice);
                var vertexShader = CompileShader(graphicsDevice, GraphicsShaderKind.Vertex, shaderName, vertexShaderEntryPoint);
                var pixelShader = CompileShader(graphicsDevice, GraphicsShaderKind.Pixel, shaderName, pixelShaderEntryPoint);

                return graphicsDevice.CreateGraphicsPipeline(signature, vertexShader, pixelShader);
            }

            GraphicsPipelineSignature CreateGraphicsPipelineSignature(GraphicsDevice graphicsDevice)
            {
                var inputs = new GraphicsPipelineInput[1] {
                    new GraphicsPipelineInput(
                        new GraphicsPipelineInputElement[2] {
                            new GraphicsPipelineInputElement(typeof(Vector3), GraphicsPipelineInputElementKind.Position, size: 12),
                            new GraphicsPipelineInputElement(typeof(Vector4), GraphicsPipelineInputElementKind.Color, size: 16),
                        }
                    ),
                };

                return graphicsDevice.CreateGraphicsPipelineSignature(inputs);
            }
        }
    }
}
