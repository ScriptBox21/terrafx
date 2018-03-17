// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public /* blittable */ unsafe struct VkRenderPassCreateInfo
    {
        #region Fields
        public VkStructureType sType;

        public void* pNext;

        [ComAliasName("VkRenderPassCreateFlags")]
        public uint flags;

        public uint attachmentCount;

        [ComAliasName("VkAttachmentDescription[]")]
        public VkAttachmentDescription* pAttachments;

        public uint subpassCount;

        [ComAliasName("VkSubpassDescription[]")]
        public VkSubpassDescription* pSubpasses;

        public uint dependencyCount;

        [ComAliasName("VkSubpassDependency[]")]
        public VkSubpassDependency* pDependencies;
        #endregion
    }
}