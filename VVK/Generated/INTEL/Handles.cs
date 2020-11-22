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

public unsafe sealed partial class VkPerformanceConfigurationINTEL : IVulkanHandle<VkPerformanceConfigurationINTEL>
{
	public readonly VulkanHandle<VkPerformanceConfigurationINTEL> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkPerformanceConfigurationINTEL(VulkanHandle<VkPerformanceConfigurationINTEL> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkPerformanceConfigurationINTEL h) && (h.Handle == Handle);
	bool IEquatable<VkPerformanceConfigurationINTEL>.Equals(VkPerformanceConfigurationINTEL? other) => other?.Handle == Handle;

	public static bool operator == (VkPerformanceConfigurationINTEL? l, VkPerformanceConfigurationINTEL? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkPerformanceConfigurationINTEL? l, VkPerformanceConfigurationINTEL? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkPerformanceConfigurationINTEL> (VkPerformanceConfigurationINTEL? h) => h?.Handle ?? VulkanHandle<VkPerformanceConfigurationINTEL>.Null;
	public static implicit operator bool (VkPerformanceConfigurationINTEL? h) => h?.IsValid ?? false;

	public VkResult ReleasePerformanceConfigurationINTEL()
		=> Functions.vkReleasePerformanceConfigurationINTEL(Parent, Handle);

}


} // namespace Vulkan

