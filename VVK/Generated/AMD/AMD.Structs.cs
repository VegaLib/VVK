﻿/*
 * MIT License - Copyright(c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at<https://opensource.org/licenses/MIT>.
 */

/// This file was generated by VVKGen. Edits to this file will be lost on next generation.

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace Vk.AMD
{

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct PipelineRasterizationStateRasterizationOrder : IEquatable<PipelineRasterizationStateRasterizationOrder>
{
	public const Vk.StructureType TYPE = Vk.StructureType.PipelineRasterizationStateRasterizationOrderAMD;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.AMD.RasterizationOrder RasterizationOrder;

	public readonly override bool Equals(object? obj) => (obj is PipelineRasterizationStateRasterizationOrder o) && (this == o);
	readonly bool IEquatable<PipelineRasterizationStateRasterizationOrder>.Equals(PipelineRasterizationStateRasterizationOrder obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<PipelineRasterizationStateRasterizationOrder>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in PipelineRasterizationStateRasterizationOrder l, in PipelineRasterizationStateRasterizationOrder r)
	{
		fixed (PipelineRasterizationStateRasterizationOrder* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<PipelineRasterizationStateRasterizationOrder>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<PipelineRasterizationStateRasterizationOrder>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in PipelineRasterizationStateRasterizationOrder l, in PipelineRasterizationStateRasterizationOrder r)
	{
		fixed (PipelineRasterizationStateRasterizationOrder* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<PipelineRasterizationStateRasterizationOrder>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<PipelineRasterizationStateRasterizationOrder>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new PipelineRasterizationStateRasterizationOrder value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out PipelineRasterizationStateRasterizationOrder value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref PipelineRasterizationStateRasterizationOrder value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct DisplayNativeHdrSurfaceCapabilities : IEquatable<DisplayNativeHdrSurfaceCapabilities>
{
	public const Vk.StructureType TYPE = Vk.StructureType.DisplayNativeHdrSurfaceCapabilitiesAMD;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.Bool32 LocalDimmingSupport;

	public readonly override bool Equals(object? obj) => (obj is DisplayNativeHdrSurfaceCapabilities o) && (this == o);
	readonly bool IEquatable<DisplayNativeHdrSurfaceCapabilities>.Equals(DisplayNativeHdrSurfaceCapabilities obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<DisplayNativeHdrSurfaceCapabilities>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in DisplayNativeHdrSurfaceCapabilities l, in DisplayNativeHdrSurfaceCapabilities r)
	{
		fixed (DisplayNativeHdrSurfaceCapabilities* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<DisplayNativeHdrSurfaceCapabilities>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<DisplayNativeHdrSurfaceCapabilities>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in DisplayNativeHdrSurfaceCapabilities l, in DisplayNativeHdrSurfaceCapabilities r)
	{
		fixed (DisplayNativeHdrSurfaceCapabilities* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<DisplayNativeHdrSurfaceCapabilities>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<DisplayNativeHdrSurfaceCapabilities>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new DisplayNativeHdrSurfaceCapabilities value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out DisplayNativeHdrSurfaceCapabilities value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref DisplayNativeHdrSurfaceCapabilities value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct SwapchainDisplayNativeHdrCreateInfo : IEquatable<SwapchainDisplayNativeHdrCreateInfo>
{
	public const Vk.StructureType TYPE = Vk.StructureType.SwapchainDisplayNativeHdrCreateInfoAMD;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.Bool32 LocalDimmingEnable;

	public readonly override bool Equals(object? obj) => (obj is SwapchainDisplayNativeHdrCreateInfo o) && (this == o);
	readonly bool IEquatable<SwapchainDisplayNativeHdrCreateInfo>.Equals(SwapchainDisplayNativeHdrCreateInfo obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<SwapchainDisplayNativeHdrCreateInfo>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in SwapchainDisplayNativeHdrCreateInfo l, in SwapchainDisplayNativeHdrCreateInfo r)
	{
		fixed (SwapchainDisplayNativeHdrCreateInfo* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<SwapchainDisplayNativeHdrCreateInfo>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<SwapchainDisplayNativeHdrCreateInfo>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in SwapchainDisplayNativeHdrCreateInfo l, in SwapchainDisplayNativeHdrCreateInfo r)
	{
		fixed (SwapchainDisplayNativeHdrCreateInfo* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<SwapchainDisplayNativeHdrCreateInfo>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<SwapchainDisplayNativeHdrCreateInfo>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new SwapchainDisplayNativeHdrCreateInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out SwapchainDisplayNativeHdrCreateInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref SwapchainDisplayNativeHdrCreateInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct TextureLODGatherFormatProperties : IEquatable<TextureLODGatherFormatProperties>
{
	public const Vk.StructureType TYPE = Vk.StructureType.TextureLodGatherFormatPropertiesAMD;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.Bool32 SupportsTextureGatherLODBiasAMD;

	public readonly override bool Equals(object? obj) => (obj is TextureLODGatherFormatProperties o) && (this == o);
	readonly bool IEquatable<TextureLODGatherFormatProperties>.Equals(TextureLODGatherFormatProperties obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<TextureLODGatherFormatProperties>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in TextureLODGatherFormatProperties l, in TextureLODGatherFormatProperties r)
	{
		fixed (TextureLODGatherFormatProperties* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<TextureLODGatherFormatProperties>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<TextureLODGatherFormatProperties>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in TextureLODGatherFormatProperties l, in TextureLODGatherFormatProperties r)
	{
		fixed (TextureLODGatherFormatProperties* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<TextureLODGatherFormatProperties>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<TextureLODGatherFormatProperties>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new TextureLODGatherFormatProperties value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out TextureLODGatherFormatProperties value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref TextureLODGatherFormatProperties value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ShaderResourceUsage : IEquatable<ShaderResourceUsage>
{
	public uint NumUsedVgprs;
	public uint NumUsedSgprs;
	public uint LdsSizePerLocalWorkGroup;
	public ulong LdsUsageSizeInBytes;
	public ulong ScratchMemUsageInBytes;

	public readonly override bool Equals(object? obj) => (obj is ShaderResourceUsage o) && (this == o);
	readonly bool IEquatable<ShaderResourceUsage>.Equals(ShaderResourceUsage obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (uint* ptr = &NumUsedVgprs) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<ShaderResourceUsage>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in ShaderResourceUsage l, in ShaderResourceUsage r)
	{
		fixed (ShaderResourceUsage* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<ShaderResourceUsage>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<ShaderResourceUsage>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in ShaderResourceUsage l, in ShaderResourceUsage r)
	{
		fixed (ShaderResourceUsage* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<ShaderResourceUsage>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<ShaderResourceUsage>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}

}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ShaderStatisticsInfo : IEquatable<ShaderStatisticsInfo>
{
	public Vk.ShaderStageFlags ShaderStageMask;
	public Vk.AMD.ShaderResourceUsage ResourceUsage;
	public uint NumPhysicalVgprs;
	public uint NumPhysicalSgprs;
	public uint NumAvailableVgprs;
	public uint NumAvailableSgprs;
	public fixed uint ComputeWorkGroupSize[3];

	public readonly override bool Equals(object? obj) => (obj is ShaderStatisticsInfo o) && (this == o);
	readonly bool IEquatable<ShaderStatisticsInfo>.Equals(ShaderStatisticsInfo obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.ShaderStageFlags* ptr = &ShaderStageMask) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<ShaderStatisticsInfo>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in ShaderStatisticsInfo l, in ShaderStatisticsInfo r)
	{
		fixed (ShaderStatisticsInfo* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<ShaderStatisticsInfo>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<ShaderStatisticsInfo>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in ShaderStatisticsInfo l, in ShaderStatisticsInfo r)
	{
		fixed (ShaderStatisticsInfo* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<ShaderStatisticsInfo>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<ShaderStatisticsInfo>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}

}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct PhysicalDeviceShaderCoreProperties : IEquatable<PhysicalDeviceShaderCoreProperties>
{
	public const Vk.StructureType TYPE = Vk.StructureType.PhysicalDeviceShaderCorePropertiesAMD;

	public Vk.StructureType sType;
	public void* pNext;
	public uint ShaderEngineCount;
	public uint ShaderArraysPerEngineCount;
	public uint ComputeUnitsPerShaderArray;
	public uint SimdPerComputeUnit;
	public uint WavefrontsPerSimd;
	public uint WavefrontSize;
	public uint SgprsPerSimd;
	public uint MinSgprAllocation;
	public uint MaxSgprAllocation;
	public uint SgprAllocationGranularity;
	public uint VgprsPerSimd;
	public uint MinVgprAllocation;
	public uint MaxVgprAllocation;
	public uint VgprAllocationGranularity;

	public readonly override bool Equals(object? obj) => (obj is PhysicalDeviceShaderCoreProperties o) && (this == o);
	readonly bool IEquatable<PhysicalDeviceShaderCoreProperties>.Equals(PhysicalDeviceShaderCoreProperties obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<PhysicalDeviceShaderCoreProperties>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in PhysicalDeviceShaderCoreProperties l, in PhysicalDeviceShaderCoreProperties r)
	{
		fixed (PhysicalDeviceShaderCoreProperties* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<PhysicalDeviceShaderCoreProperties>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<PhysicalDeviceShaderCoreProperties>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in PhysicalDeviceShaderCoreProperties l, in PhysicalDeviceShaderCoreProperties r)
	{
		fixed (PhysicalDeviceShaderCoreProperties* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<PhysicalDeviceShaderCoreProperties>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<PhysicalDeviceShaderCoreProperties>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new PhysicalDeviceShaderCoreProperties value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out PhysicalDeviceShaderCoreProperties value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref PhysicalDeviceShaderCoreProperties value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct PhysicalDeviceShaderCoreProperties2 : IEquatable<PhysicalDeviceShaderCoreProperties2>
{
	public const Vk.StructureType TYPE = Vk.StructureType.PhysicalDeviceShaderCoreProperties2AMD;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.AMD.ShaderCorePropertiesFlags ShaderCoreFeatures;
	public uint ActiveComputeUnitCount;

	public readonly override bool Equals(object? obj) => (obj is PhysicalDeviceShaderCoreProperties2 o) && (this == o);
	readonly bool IEquatable<PhysicalDeviceShaderCoreProperties2>.Equals(PhysicalDeviceShaderCoreProperties2 obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<PhysicalDeviceShaderCoreProperties2>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in PhysicalDeviceShaderCoreProperties2 l, in PhysicalDeviceShaderCoreProperties2 r)
	{
		fixed (PhysicalDeviceShaderCoreProperties2* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<PhysicalDeviceShaderCoreProperties2>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<PhysicalDeviceShaderCoreProperties2>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in PhysicalDeviceShaderCoreProperties2 l, in PhysicalDeviceShaderCoreProperties2 r)
	{
		fixed (PhysicalDeviceShaderCoreProperties2* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<PhysicalDeviceShaderCoreProperties2>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<PhysicalDeviceShaderCoreProperties2>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new PhysicalDeviceShaderCoreProperties2 value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out PhysicalDeviceShaderCoreProperties2 value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref PhysicalDeviceShaderCoreProperties2 value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct DeviceMemoryOverallocationCreateInfo : IEquatable<DeviceMemoryOverallocationCreateInfo>
{
	public const Vk.StructureType TYPE = Vk.StructureType.DeviceMemoryOverallocationCreateInfoAMD;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.AMD.MemoryOverallocationBehavior OverallocationBehavior;

	public readonly override bool Equals(object? obj) => (obj is DeviceMemoryOverallocationCreateInfo o) && (this == o);
	readonly bool IEquatable<DeviceMemoryOverallocationCreateInfo>.Equals(DeviceMemoryOverallocationCreateInfo obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<DeviceMemoryOverallocationCreateInfo>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in DeviceMemoryOverallocationCreateInfo l, in DeviceMemoryOverallocationCreateInfo r)
	{
		fixed (DeviceMemoryOverallocationCreateInfo* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<DeviceMemoryOverallocationCreateInfo>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<DeviceMemoryOverallocationCreateInfo>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in DeviceMemoryOverallocationCreateInfo l, in DeviceMemoryOverallocationCreateInfo r)
	{
		fixed (DeviceMemoryOverallocationCreateInfo* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<DeviceMemoryOverallocationCreateInfo>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<DeviceMemoryOverallocationCreateInfo>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new DeviceMemoryOverallocationCreateInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out DeviceMemoryOverallocationCreateInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref DeviceMemoryOverallocationCreateInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct PipelineCompilerControlCreateInfo : IEquatable<PipelineCompilerControlCreateInfo>
{
	public const Vk.StructureType TYPE = Vk.StructureType.PipelineCompilerControlCreateInfoAMD;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.AMD.PipelineCompilerControlFlags CompilerControlFlags;

	public readonly override bool Equals(object? obj) => (obj is PipelineCompilerControlCreateInfo o) && (this == o);
	readonly bool IEquatable<PipelineCompilerControlCreateInfo>.Equals(PipelineCompilerControlCreateInfo obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<PipelineCompilerControlCreateInfo>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in PipelineCompilerControlCreateInfo l, in PipelineCompilerControlCreateInfo r)
	{
		fixed (PipelineCompilerControlCreateInfo* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<PipelineCompilerControlCreateInfo>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<PipelineCompilerControlCreateInfo>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in PipelineCompilerControlCreateInfo l, in PipelineCompilerControlCreateInfo r)
	{
		fixed (PipelineCompilerControlCreateInfo* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<PipelineCompilerControlCreateInfo>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<PipelineCompilerControlCreateInfo>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new PipelineCompilerControlCreateInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out PipelineCompilerControlCreateInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref PipelineCompilerControlCreateInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct PhysicalDeviceCoherentMemoryFeatures : IEquatable<PhysicalDeviceCoherentMemoryFeatures>
{
	public const Vk.StructureType TYPE = Vk.StructureType.PhysicalDeviceCoherentMemoryFeaturesAMD;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.Bool32 DeviceCoherentMemory;

	public readonly override bool Equals(object? obj) => (obj is PhysicalDeviceCoherentMemoryFeatures o) && (this == o);
	readonly bool IEquatable<PhysicalDeviceCoherentMemoryFeatures>.Equals(PhysicalDeviceCoherentMemoryFeatures obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<PhysicalDeviceCoherentMemoryFeatures>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in PhysicalDeviceCoherentMemoryFeatures l, in PhysicalDeviceCoherentMemoryFeatures r)
	{
		fixed (PhysicalDeviceCoherentMemoryFeatures* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<PhysicalDeviceCoherentMemoryFeatures>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<PhysicalDeviceCoherentMemoryFeatures>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in PhysicalDeviceCoherentMemoryFeatures l, in PhysicalDeviceCoherentMemoryFeatures r)
	{
		fixed (PhysicalDeviceCoherentMemoryFeatures* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<PhysicalDeviceCoherentMemoryFeatures>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<PhysicalDeviceCoherentMemoryFeatures>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new PhysicalDeviceCoherentMemoryFeatures value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out PhysicalDeviceCoherentMemoryFeatures value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref PhysicalDeviceCoherentMemoryFeatures value) { value.sType = TYPE; value.pNext = null; }
}

} // namespace Vk.AMD
