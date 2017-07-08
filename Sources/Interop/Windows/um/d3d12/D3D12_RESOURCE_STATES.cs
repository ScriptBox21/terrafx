// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D12_RESOURCE_STATES
    {
        D3D12_RESOURCE_STATE_COMMON = 0,

        D3D12_RESOURCE_STATE_VERTEX_AND_CONSTANT_BUFFER = 0x1,

        D3D12_RESOURCE_STATE_INDEX_BUFFER = 0x2,

        D3D12_RESOURCE_STATE_RENDER_TARGET = 0x4,

        D3D12_RESOURCE_STATE_UNORDERED_ACCESS = 0x8,

        D3D12_RESOURCE_STATE_DEPTH_WRITE = 0x10,

        D3D12_RESOURCE_STATE_DEPTH_READ = 0x20,

        D3D12_RESOURCE_STATE_NON_PIXEL_SHADER_RESOURCE = 0x40,

        D3D12_RESOURCE_STATE_PIXEL_SHADER_RESOURCE = 0x80,

        D3D12_RESOURCE_STATE_STREAM_OUT = 0x100,

        D3D12_RESOURCE_STATE_INDIRECT_ARGUMENT = 0x200,

        D3D12_RESOURCE_STATE_COPY_DEST = 0x400,

        D3D12_RESOURCE_STATE_COPY_SOURCE = 0x800,

        D3D12_RESOURCE_STATE_RESOLVE_DEST = 0x1000,

        D3D12_RESOURCE_STATE_RESOLVE_SOURCE = 0x2000,

        D3D12_RESOURCE_STATE_GENERIC_READ = (((((0x1 | 0x2) | 0x40) | 0x80) | 0x200) | 0x800),

        D3D12_RESOURCE_STATE_PRESENT = 0,

        D3D12_RESOURCE_STATE_PREDICATION = 0x200
    }
}
