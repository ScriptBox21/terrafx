// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12sdklayers.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class D3D12
    {
        #region Constants
        public static readonly GUID DXGI_DEBUG_D3D12 = new Guid(0xCF59A98C, 0xA950, 0x4326, 0x91, 0xEF, 0x9B, 0xBA, 0xA1, 0x7B, 0xFD, 0x95);

        #region IID_*
        public static readonly GUID IID_ID3D12Debug = new Guid(0x344488B7, 0x6846, 0x474B, 0xB9, 0x89, 0xF0, 0x27, 0x44, 0x82, 0x45, 0xE0);

        public static readonly GUID IID_ID3D12Debug1 = new Guid(0xAFFAA4CA, 0x63FE, 0x4D8E, 0xB8, 0xAD, 0x15, 0x90, 0x00, 0xAF, 0x43, 0x04);

        public static readonly GUID IID_ID3D12Debug2 = new Guid(0x93A665C4, 0xA3B2, 0x4E5D, 0xB6, 0x92, 0xA2, 0x6A, 0xE1, 0x4E, 0x33, 0x74);

        public static readonly GUID IID_ID3D12DebugDevice1 = new Guid(0xA9B71770, 0xD099, 0x4A65, 0xA6, 0x98, 0x3D, 0xEE, 0x10, 0x02, 0x0F, 0x88);

        public static readonly GUID IID_ID3D12DebugDevice = new Guid(0x3FEBD6DD, 0x4973, 0x4787, 0x81, 0x94, 0xE4, 0x5F, 0x9E, 0x28, 0x92, 0x3E);

        public static readonly GUID IID_ID3D12DebugCommandQueue = new Guid(0x09E0BF36, 0x54AC, 0x484F, 0x88, 0x47, 0x4B, 0xAE, 0xEA, 0xB6, 0x05, 0x3A);

        public static readonly GUID IID_ID3D12DebugCommandList1 = new Guid(0x102CA951, 0x311B, 0x4B01, 0xB1, 0x1F, 0xEC, 0xB8, 0x3E, 0x06, 0x1B, 0x37);

        public static readonly GUID IID_ID3D12DebugCommandList = new Guid(0x09E0BF36, 0x54AC, 0x484F, 0x88, 0x47, 0x4B, 0xAE, 0xEA, 0xB6, 0x05, 0x3F);

        public static readonly GUID IID_ID3D12InfoQueue = new Guid(0x0742A90B, 0xC387, 0x483F, 0xB9, 0x46, 0x30, 0xA7, 0xE4, 0xE6, 0x14, 0x58);
        #endregion
        #endregion
    }
}
