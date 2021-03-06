// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Threading;
using static TerraFX.Utilities.ExceptionUtilities;

namespace TerraFX.Graphics
{
    /// <summary>A graphics fence which can be used to synchronize the processor and a graphics context.</summary>
    public abstract class GraphicsFence : IDisposable
    {
        private readonly GraphicsDevice _device;

        /// <summary>Initializes a new instance of the <see cref="GraphicsFence" /> class.</summary>
        /// <param name="device">The device for which the fence provides synchronization.</param>
        /// <exception cref="ArgumentNullException"><paramref name="device" /> is <c>null</c>.</exception>
        protected GraphicsFence(GraphicsDevice device)
        {
            ThrowIfNull(device, nameof(device));
            _device = device;
        }

        /// <summary>Gets the device for which the fence provides synchronization.</summary>
        public GraphicsDevice Device => _device;

        /// <summary>Gets <c>true</c> if the fence is in the signalled state; otherwise, <c>false</c>.</summary>
        /// <exception cref="ObjectDisposedException">The fence has been disposed.</exception>
        public abstract bool IsSignalled { get; }

        /// <summary>Resets the fence to the unsignalled state.</summary>
        /// <exception cref="ObjectDisposedException">The fence has been disposed.</exception>
        /// <remarks>This method does nothing if the fence is already in the unsignalled state.</remarks>
        public abstract void Reset();

        /// <summary>Waits for the fence to transition to the signalled state or the timeout to be reached, whichever occurs first.</summary>
        /// <param name="millisecondsTimeout">The amount of time, in milliseconds, to wait for the fence to transition to the signalled state before failing.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is negative and is not <see cref="Timeout.Infinite" />.</exception>
        /// <exception cref="ObjectDisposedException">The fence has been disposed.</exception>
        /// <exception cref="TimeoutException"><paramref name="millisecondsTimeout" /> was reached before the fence transitioned to the signalled state.</exception>
        /// <remarks>This method treats <see cref="Timeout.Infinite" /> as having no timeout.</remarks>
        public void Wait(int millisecondsTimeout = Timeout.Infinite)
        {
            if (!TryWait(millisecondsTimeout))
            {
                ThrowTimeoutException(TimeSpan.FromMilliseconds(millisecondsTimeout));
            }
        }

        /// <summary>Waits for the fence to transition to the signalled state or the timeout to be reached, whichever occurs first.</summary>
        /// <param name="timeout">The amount of time to wait for the fence to transition to the signalled state before failing.</param>
        /// <exception cref="ObjectDisposedException">The fence has been disposed.</exception>
        /// <exception cref="TimeoutException"><paramref name="timeout" /> was reached before the fence transitioned to the signalled state.</exception>
        /// <remarks>This method treats <see cref="Timeout.Infinite" /> as having no timeout.</remarks>
        public void Wait(TimeSpan timeout)
        {
            if (!TryWait(timeout))
            {
                ThrowTimeoutException(timeout);
            }
        }

        /// <summary>Waits for the fence to transition to the signalled state or the timeout to be reached, whichever occurs first.</summary>
        /// <param name="millisecondsTimeout">The amount of time, in milliseconds, to wait for the fence to transition to the signalled state before failing.</param>
        /// <returns><c>true</c> if the fence transitioned to the signalled state; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is negative and is not <see cref="Timeout.Infinite" />.</exception>
        /// <exception cref="ObjectDisposedException">The fence has been disposed.</exception>
        /// <remarks>This method treats <see cref="Timeout.Infinite" /> as having no timeout.</remarks>
        public abstract bool TryWait(int millisecondsTimeout = Timeout.Infinite);

        /// <summary>Waits for the fence to transition to the signalled state or the timeout to be reached, whichever occurs first.</summary>
        /// <param name="timeout">The amount of time to wait for the fence to transition to the signalled state before failing.</param>
        /// <returns><c>true</c> if the fence transitioned to the signalled state; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="timeout" /> is negative and is not <see cref="Timeout.InfiniteTimeSpan" />.</exception>
        /// <exception cref="ObjectDisposedException">The fence has been disposed.</exception>
        /// <remarks>This method treats <see cref="Timeout.InfiniteTimeSpan" /> as having no timeout.</remarks>
        public abstract bool TryWait(TimeSpan timeout);

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(isDisposing: true);
            GC.SuppressFinalize(this);
        }

        /// <inheritdoc cref="Dispose()" />
        /// <param name="isDisposing"><c>true</c> if the method was called from <see cref="Dispose()" />; otherwise, <c>false</c>.</param>
        protected abstract void Dispose(bool isDisposing);
    }
}
