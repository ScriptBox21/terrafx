// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public /* blittable */ struct D3D12_RECT
    {
        #region Fields
        internal RECT _value;
        #endregion

        #region Constructors
        /// <summary>Initializes a new instance of the <see cref="D3D12_RECT" /> struct.</summary>
        /// <param name="value">The <see cref="RECT" /> used to initialize the instance.</param>
        public D3D12_RECT(RECT value)
        {
            _value = value;
        }
        #endregion

        #region Operators
        /// <summary>Explicitly converts a <see cref="D3D12_RECT" /> value to a <see cref="RECT" /> value.</summary>
        /// <param name="value">The <see cref="D3D12_RECT" /> value to convert.</param>
        public static implicit operator RECT(D3D12_RECT value)
        {
            return value._value;
        }

        /// <summary>Implicitly converts a <see cref="RECT" /> value to a <see cref="D3D12_RECT" /> value.</summary>
        /// <param name="value">The <see cref="RECT" /> value to convert.</param>
        public static implicit operator D3D12_RECT(RECT value)
        {
            return new D3D12_RECT(value);
        }
        #endregion
    }
}
