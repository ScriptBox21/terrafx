// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("D8CD007F-D08F-4191-9BFC-236EA7F0E4B5")]
    unsafe public /* blittable */ struct IWICBitmapDecoderInfo
    {
        #region Fields
        public readonly void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT GetPatterns(
            [In] IWICBitmapDecoderInfo* This,
            [In] UINT cbSizePatterns,
            [Out, Optional] WICBitmapPattern* pPatterns,
            [Out, Optional] UINT* pcPatterns,
            [Out] UINT* pcbPatternsActual
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT MatchesPattern(
            [In] IWICBitmapDecoderInfo* This,
            [In, Optional] IStream* pIStream,
            [Out] BOOL* pfMatches
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateInstance(
            [In] IWICBitmapDecoderInfo* This,
            [Out, Optional] IWICBitmapDecoder** ppIBitmapDecoder
        );
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region Fields
            public IWICBitmapCodecInfo.Vtbl BaseVtbl;

            public GetPatterns GetPatterns;

            public MatchesPattern MatchesPattern;

            public CreateInstance CreateInstance;
            #endregion
        }
        #endregion
    }
}