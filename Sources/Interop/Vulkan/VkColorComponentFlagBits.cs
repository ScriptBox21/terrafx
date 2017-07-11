// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkColorComponentFlagBits : uint
    {
        VK_COLOR_COMPONENT_R_BIT = 0x00000001,

        VK_COLOR_COMPONENT_G_BIT = 0x00000002,

        VK_COLOR_COMPONENT_B_BIT = 0x00000004,

        VK_COLOR_COMPONENT_A_BIT = 0x00000008,

        VK_COLOR_COMPONENT_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
}