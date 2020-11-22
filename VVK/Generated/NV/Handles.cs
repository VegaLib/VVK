﻿/*
 * MIT License - Copyright(c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at <https://opensource.org/licenses/MIT>.
 */

/// This file was generated by VVKGen. Edits to this file will be lost on next generation.

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Vulkan
{

public unsafe sealed partial class VkIndirectCommandsLayoutNV : IVulkanHandle<VkIndirectCommandsLayoutNV>
{
	public readonly VulkanHandle<VkIndirectCommandsLayoutNV> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkIndirectCommandsLayoutNV(VulkanHandle<VkIndirectCommandsLayoutNV> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkIndirectCommandsLayoutNV h) && (h.Handle == Handle);
	bool IEquatable<VkIndirectCommandsLayoutNV>.Equals(VkIndirectCommandsLayoutNV? other) => other?.Handle == Handle;

	public static bool operator == (VkIndirectCommandsLayoutNV? l, VkIndirectCommandsLayoutNV? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkIndirectCommandsLayoutNV? l, VkIndirectCommandsLayoutNV? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkIndirectCommandsLayoutNV> (VkIndirectCommandsLayoutNV? h) => h?.Handle ?? VulkanHandle<VkIndirectCommandsLayoutNV>.Null;
	public static implicit operator bool (VkIndirectCommandsLayoutNV? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkAccelerationStructureNV : IVulkanHandle<VkAccelerationStructureNV>
{
	public readonly VulkanHandle<VkAccelerationStructureNV> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkAccelerationStructureNV(VulkanHandle<VkAccelerationStructureNV> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkAccelerationStructureNV h) && (h.Handle == Handle);
	bool IEquatable<VkAccelerationStructureNV>.Equals(VkAccelerationStructureNV? other) => other?.Handle == Handle;

	public static bool operator == (VkAccelerationStructureNV? l, VkAccelerationStructureNV? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkAccelerationStructureNV? l, VkAccelerationStructureNV? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkAccelerationStructureNV> (VkAccelerationStructureNV? h) => h?.Handle ?? VulkanHandle<VkAccelerationStructureNV>.Null;
	public static implicit operator bool (VkAccelerationStructureNV? h) => h?.IsValid ?? false;
}


} // namespace Vulkan
