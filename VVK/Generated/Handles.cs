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

public unsafe sealed partial class VkInstance : IVulkanHandle<VkInstance>
{
	public readonly VulkanHandle<VkInstance> Handle;
	public readonly InstanceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkInstance(VulkanHandle<VkInstance> handle, VkVersion apiVersion)
	{
		Handle = handle;
		Functions = handle ? new(handle, apiVersion) : new();
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkInstance h) && (h.Handle == Handle);
	bool IEquatable<VkInstance>.Equals(VkInstance? other) => other?.Handle == Handle;

	public static bool operator == (VkInstance? l, VkInstance? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkInstance? l, VkInstance? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkInstance> (VkInstance? h) => h?.Handle ?? VulkanHandle<VkInstance>.Null;
	public static implicit operator bool (VkInstance? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkPhysicalDevice : IVulkanHandle<VkPhysicalDevice>
{
	public readonly VulkanHandle<VkPhysicalDevice> Handle;
	public readonly VkInstance Parent;
	public readonly InstanceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkPhysicalDevice(VulkanHandle<VkPhysicalDevice> handle, VkInstance parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkPhysicalDevice h) && (h.Handle == Handle);
	bool IEquatable<VkPhysicalDevice>.Equals(VkPhysicalDevice? other) => other?.Handle == Handle;

	public static bool operator == (VkPhysicalDevice? l, VkPhysicalDevice? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkPhysicalDevice? l, VkPhysicalDevice? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkPhysicalDevice> (VkPhysicalDevice? h) => h?.Handle ?? VulkanHandle<VkPhysicalDevice>.Null;
	public static implicit operator bool (VkPhysicalDevice? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkDevice : IVulkanHandle<VkDevice>
{
	public readonly VulkanHandle<VkDevice> Handle;
	public readonly VkPhysicalDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkDevice(VulkanHandle<VkDevice> handle, VkPhysicalDevice parent, VkVersion apiVersion)
	{
		Handle = handle;
		Parent = parent;
		Functions = handle ? new(handle, apiVersion) : new();
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkDevice h) && (h.Handle == Handle);
	bool IEquatable<VkDevice>.Equals(VkDevice? other) => other?.Handle == Handle;

	public static bool operator == (VkDevice? l, VkDevice? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkDevice? l, VkDevice? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkDevice> (VkDevice? h) => h?.Handle ?? VulkanHandle<VkDevice>.Null;
	public static implicit operator bool (VkDevice? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkQueue : IVulkanHandle<VkQueue>
{
	public readonly VulkanHandle<VkQueue> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkQueue(VulkanHandle<VkQueue> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkQueue h) && (h.Handle == Handle);
	bool IEquatable<VkQueue>.Equals(VkQueue? other) => other?.Handle == Handle;

	public static bool operator == (VkQueue? l, VkQueue? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkQueue? l, VkQueue? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkQueue> (VkQueue? h) => h?.Handle ?? VulkanHandle<VkQueue>.Null;
	public static implicit operator bool (VkQueue? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkCommandBuffer : IVulkanHandle<VkCommandBuffer>
{
	public readonly VulkanHandle<VkCommandBuffer> Handle;
	public readonly VkCommandPool Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkCommandBuffer(VulkanHandle<VkCommandBuffer> handle, VkCommandPool parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkCommandBuffer h) && (h.Handle == Handle);
	bool IEquatable<VkCommandBuffer>.Equals(VkCommandBuffer? other) => other?.Handle == Handle;

	public static bool operator == (VkCommandBuffer? l, VkCommandBuffer? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkCommandBuffer? l, VkCommandBuffer? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkCommandBuffer> (VkCommandBuffer? h) => h?.Handle ?? VulkanHandle<VkCommandBuffer>.Null;
	public static implicit operator bool (VkCommandBuffer? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkDeviceMemory : IVulkanHandle<VkDeviceMemory>
{
	public readonly VulkanHandle<VkDeviceMemory> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkDeviceMemory(VulkanHandle<VkDeviceMemory> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkDeviceMemory h) && (h.Handle == Handle);
	bool IEquatable<VkDeviceMemory>.Equals(VkDeviceMemory? other) => other?.Handle == Handle;

	public static bool operator == (VkDeviceMemory? l, VkDeviceMemory? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkDeviceMemory? l, VkDeviceMemory? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkDeviceMemory> (VkDeviceMemory? h) => h?.Handle ?? VulkanHandle<VkDeviceMemory>.Null;
	public static implicit operator bool (VkDeviceMemory? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkCommandPool : IVulkanHandle<VkCommandPool>
{
	public readonly VulkanHandle<VkCommandPool> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkCommandPool(VulkanHandle<VkCommandPool> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkCommandPool h) && (h.Handle == Handle);
	bool IEquatable<VkCommandPool>.Equals(VkCommandPool? other) => other?.Handle == Handle;

	public static bool operator == (VkCommandPool? l, VkCommandPool? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkCommandPool? l, VkCommandPool? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkCommandPool> (VkCommandPool? h) => h?.Handle ?? VulkanHandle<VkCommandPool>.Null;
	public static implicit operator bool (VkCommandPool? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkBuffer : IVulkanHandle<VkBuffer>
{
	public readonly VulkanHandle<VkBuffer> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkBuffer(VulkanHandle<VkBuffer> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkBuffer h) && (h.Handle == Handle);
	bool IEquatable<VkBuffer>.Equals(VkBuffer? other) => other?.Handle == Handle;

	public static bool operator == (VkBuffer? l, VkBuffer? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkBuffer? l, VkBuffer? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkBuffer> (VkBuffer? h) => h?.Handle ?? VulkanHandle<VkBuffer>.Null;
	public static implicit operator bool (VkBuffer? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkBufferView : IVulkanHandle<VkBufferView>
{
	public readonly VulkanHandle<VkBufferView> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkBufferView(VulkanHandle<VkBufferView> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkBufferView h) && (h.Handle == Handle);
	bool IEquatable<VkBufferView>.Equals(VkBufferView? other) => other?.Handle == Handle;

	public static bool operator == (VkBufferView? l, VkBufferView? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkBufferView? l, VkBufferView? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkBufferView> (VkBufferView? h) => h?.Handle ?? VulkanHandle<VkBufferView>.Null;
	public static implicit operator bool (VkBufferView? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkImage : IVulkanHandle<VkImage>
{
	public readonly VulkanHandle<VkImage> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkImage(VulkanHandle<VkImage> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkImage h) && (h.Handle == Handle);
	bool IEquatable<VkImage>.Equals(VkImage? other) => other?.Handle == Handle;

	public static bool operator == (VkImage? l, VkImage? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkImage? l, VkImage? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkImage> (VkImage? h) => h?.Handle ?? VulkanHandle<VkImage>.Null;
	public static implicit operator bool (VkImage? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkImageView : IVulkanHandle<VkImageView>
{
	public readonly VulkanHandle<VkImageView> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkImageView(VulkanHandle<VkImageView> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkImageView h) && (h.Handle == Handle);
	bool IEquatable<VkImageView>.Equals(VkImageView? other) => other?.Handle == Handle;

	public static bool operator == (VkImageView? l, VkImageView? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkImageView? l, VkImageView? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkImageView> (VkImageView? h) => h?.Handle ?? VulkanHandle<VkImageView>.Null;
	public static implicit operator bool (VkImageView? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkShaderModule : IVulkanHandle<VkShaderModule>
{
	public readonly VulkanHandle<VkShaderModule> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkShaderModule(VulkanHandle<VkShaderModule> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkShaderModule h) && (h.Handle == Handle);
	bool IEquatable<VkShaderModule>.Equals(VkShaderModule? other) => other?.Handle == Handle;

	public static bool operator == (VkShaderModule? l, VkShaderModule? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkShaderModule? l, VkShaderModule? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkShaderModule> (VkShaderModule? h) => h?.Handle ?? VulkanHandle<VkShaderModule>.Null;
	public static implicit operator bool (VkShaderModule? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkPipeline : IVulkanHandle<VkPipeline>
{
	public readonly VulkanHandle<VkPipeline> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkPipeline(VulkanHandle<VkPipeline> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkPipeline h) && (h.Handle == Handle);
	bool IEquatable<VkPipeline>.Equals(VkPipeline? other) => other?.Handle == Handle;

	public static bool operator == (VkPipeline? l, VkPipeline? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkPipeline? l, VkPipeline? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkPipeline> (VkPipeline? h) => h?.Handle ?? VulkanHandle<VkPipeline>.Null;
	public static implicit operator bool (VkPipeline? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkPipelineLayout : IVulkanHandle<VkPipelineLayout>
{
	public readonly VulkanHandle<VkPipelineLayout> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkPipelineLayout(VulkanHandle<VkPipelineLayout> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkPipelineLayout h) && (h.Handle == Handle);
	bool IEquatable<VkPipelineLayout>.Equals(VkPipelineLayout? other) => other?.Handle == Handle;

	public static bool operator == (VkPipelineLayout? l, VkPipelineLayout? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkPipelineLayout? l, VkPipelineLayout? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkPipelineLayout> (VkPipelineLayout? h) => h?.Handle ?? VulkanHandle<VkPipelineLayout>.Null;
	public static implicit operator bool (VkPipelineLayout? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkSampler : IVulkanHandle<VkSampler>
{
	public readonly VulkanHandle<VkSampler> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkSampler(VulkanHandle<VkSampler> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkSampler h) && (h.Handle == Handle);
	bool IEquatable<VkSampler>.Equals(VkSampler? other) => other?.Handle == Handle;

	public static bool operator == (VkSampler? l, VkSampler? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkSampler? l, VkSampler? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkSampler> (VkSampler? h) => h?.Handle ?? VulkanHandle<VkSampler>.Null;
	public static implicit operator bool (VkSampler? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkDescriptorSet : IVulkanHandle<VkDescriptorSet>
{
	public readonly VulkanHandle<VkDescriptorSet> Handle;
	public readonly VkDescriptorPool Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkDescriptorSet(VulkanHandle<VkDescriptorSet> handle, VkDescriptorPool parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkDescriptorSet h) && (h.Handle == Handle);
	bool IEquatable<VkDescriptorSet>.Equals(VkDescriptorSet? other) => other?.Handle == Handle;

	public static bool operator == (VkDescriptorSet? l, VkDescriptorSet? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkDescriptorSet? l, VkDescriptorSet? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkDescriptorSet> (VkDescriptorSet? h) => h?.Handle ?? VulkanHandle<VkDescriptorSet>.Null;
	public static implicit operator bool (VkDescriptorSet? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkDescriptorSetLayout : IVulkanHandle<VkDescriptorSetLayout>
{
	public readonly VulkanHandle<VkDescriptorSetLayout> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkDescriptorSetLayout(VulkanHandle<VkDescriptorSetLayout> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkDescriptorSetLayout h) && (h.Handle == Handle);
	bool IEquatable<VkDescriptorSetLayout>.Equals(VkDescriptorSetLayout? other) => other?.Handle == Handle;

	public static bool operator == (VkDescriptorSetLayout? l, VkDescriptorSetLayout? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkDescriptorSetLayout? l, VkDescriptorSetLayout? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkDescriptorSetLayout> (VkDescriptorSetLayout? h) => h?.Handle ?? VulkanHandle<VkDescriptorSetLayout>.Null;
	public static implicit operator bool (VkDescriptorSetLayout? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkDescriptorPool : IVulkanHandle<VkDescriptorPool>
{
	public readonly VulkanHandle<VkDescriptorPool> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkDescriptorPool(VulkanHandle<VkDescriptorPool> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkDescriptorPool h) && (h.Handle == Handle);
	bool IEquatable<VkDescriptorPool>.Equals(VkDescriptorPool? other) => other?.Handle == Handle;

	public static bool operator == (VkDescriptorPool? l, VkDescriptorPool? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkDescriptorPool? l, VkDescriptorPool? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkDescriptorPool> (VkDescriptorPool? h) => h?.Handle ?? VulkanHandle<VkDescriptorPool>.Null;
	public static implicit operator bool (VkDescriptorPool? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkFence : IVulkanHandle<VkFence>
{
	public readonly VulkanHandle<VkFence> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkFence(VulkanHandle<VkFence> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkFence h) && (h.Handle == Handle);
	bool IEquatable<VkFence>.Equals(VkFence? other) => other?.Handle == Handle;

	public static bool operator == (VkFence? l, VkFence? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkFence? l, VkFence? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkFence> (VkFence? h) => h?.Handle ?? VulkanHandle<VkFence>.Null;
	public static implicit operator bool (VkFence? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkSemaphore : IVulkanHandle<VkSemaphore>
{
	public readonly VulkanHandle<VkSemaphore> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkSemaphore(VulkanHandle<VkSemaphore> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkSemaphore h) && (h.Handle == Handle);
	bool IEquatable<VkSemaphore>.Equals(VkSemaphore? other) => other?.Handle == Handle;

	public static bool operator == (VkSemaphore? l, VkSemaphore? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkSemaphore? l, VkSemaphore? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkSemaphore> (VkSemaphore? h) => h?.Handle ?? VulkanHandle<VkSemaphore>.Null;
	public static implicit operator bool (VkSemaphore? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkEvent : IVulkanHandle<VkEvent>
{
	public readonly VulkanHandle<VkEvent> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkEvent(VulkanHandle<VkEvent> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkEvent h) && (h.Handle == Handle);
	bool IEquatable<VkEvent>.Equals(VkEvent? other) => other?.Handle == Handle;

	public static bool operator == (VkEvent? l, VkEvent? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkEvent? l, VkEvent? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkEvent> (VkEvent? h) => h?.Handle ?? VulkanHandle<VkEvent>.Null;
	public static implicit operator bool (VkEvent? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkQueryPool : IVulkanHandle<VkQueryPool>
{
	public readonly VulkanHandle<VkQueryPool> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkQueryPool(VulkanHandle<VkQueryPool> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkQueryPool h) && (h.Handle == Handle);
	bool IEquatable<VkQueryPool>.Equals(VkQueryPool? other) => other?.Handle == Handle;

	public static bool operator == (VkQueryPool? l, VkQueryPool? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkQueryPool? l, VkQueryPool? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkQueryPool> (VkQueryPool? h) => h?.Handle ?? VulkanHandle<VkQueryPool>.Null;
	public static implicit operator bool (VkQueryPool? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkFramebuffer : IVulkanHandle<VkFramebuffer>
{
	public readonly VulkanHandle<VkFramebuffer> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkFramebuffer(VulkanHandle<VkFramebuffer> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkFramebuffer h) && (h.Handle == Handle);
	bool IEquatable<VkFramebuffer>.Equals(VkFramebuffer? other) => other?.Handle == Handle;

	public static bool operator == (VkFramebuffer? l, VkFramebuffer? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkFramebuffer? l, VkFramebuffer? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkFramebuffer> (VkFramebuffer? h) => h?.Handle ?? VulkanHandle<VkFramebuffer>.Null;
	public static implicit operator bool (VkFramebuffer? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkRenderPass : IVulkanHandle<VkRenderPass>
{
	public readonly VulkanHandle<VkRenderPass> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkRenderPass(VulkanHandle<VkRenderPass> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkRenderPass h) && (h.Handle == Handle);
	bool IEquatable<VkRenderPass>.Equals(VkRenderPass? other) => other?.Handle == Handle;

	public static bool operator == (VkRenderPass? l, VkRenderPass? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkRenderPass? l, VkRenderPass? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkRenderPass> (VkRenderPass? h) => h?.Handle ?? VulkanHandle<VkRenderPass>.Null;
	public static implicit operator bool (VkRenderPass? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkPipelineCache : IVulkanHandle<VkPipelineCache>
{
	public readonly VulkanHandle<VkPipelineCache> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkPipelineCache(VulkanHandle<VkPipelineCache> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkPipelineCache h) && (h.Handle == Handle);
	bool IEquatable<VkPipelineCache>.Equals(VkPipelineCache? other) => other?.Handle == Handle;

	public static bool operator == (VkPipelineCache? l, VkPipelineCache? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkPipelineCache? l, VkPipelineCache? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkPipelineCache> (VkPipelineCache? h) => h?.Handle ?? VulkanHandle<VkPipelineCache>.Null;
	public static implicit operator bool (VkPipelineCache? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkDescriptorUpdateTemplate : IVulkanHandle<VkDescriptorUpdateTemplate>
{
	public readonly VulkanHandle<VkDescriptorUpdateTemplate> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkDescriptorUpdateTemplate(VulkanHandle<VkDescriptorUpdateTemplate> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkDescriptorUpdateTemplate h) && (h.Handle == Handle);
	bool IEquatable<VkDescriptorUpdateTemplate>.Equals(VkDescriptorUpdateTemplate? other) => other?.Handle == Handle;

	public static bool operator == (VkDescriptorUpdateTemplate? l, VkDescriptorUpdateTemplate? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkDescriptorUpdateTemplate? l, VkDescriptorUpdateTemplate? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkDescriptorUpdateTemplate> (VkDescriptorUpdateTemplate? h) => h?.Handle ?? VulkanHandle<VkDescriptorUpdateTemplate>.Null;
	public static implicit operator bool (VkDescriptorUpdateTemplate? h) => h?.IsValid ?? false;
}

public unsafe sealed partial class VkSamplerYcbcrConversion : IVulkanHandle<VkSamplerYcbcrConversion>
{
	public readonly VulkanHandle<VkSamplerYcbcrConversion> Handle;
	public readonly VkDevice Parent;
	public readonly DeviceFunctionTable Functions;
	public bool IsValid => Handle.IsValid;

	public VkSamplerYcbcrConversion(VulkanHandle<VkSamplerYcbcrConversion> handle, VkDevice parent)
	{
		Handle = handle;
		Parent = parent;
		Functions = parent.Functions;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => Handle.ToString();
	public override bool Equals(object? o) => (o is VkSamplerYcbcrConversion h) && (h.Handle == Handle);
	bool IEquatable<VkSamplerYcbcrConversion>.Equals(VkSamplerYcbcrConversion? other) => other?.Handle == Handle;

	public static bool operator == (VkSamplerYcbcrConversion? l, VkSamplerYcbcrConversion? r) => l?.Handle == r?.Handle;
	public static bool operator != (VkSamplerYcbcrConversion? l, VkSamplerYcbcrConversion? r) => l?.Handle != r?.Handle;

	public static implicit operator VulkanHandle<VkSamplerYcbcrConversion> (VkSamplerYcbcrConversion? h) => h?.Handle ?? VulkanHandle<VkSamplerYcbcrConversion>.Null;
	public static implicit operator bool (VkSamplerYcbcrConversion? h) => h?.IsValid ?? false;
}


} // namespace Vulkan
