﻿/*
 * MIT License - Copyright(c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at<https://opensource.org/licenses/MIT>.
 */

/// This file was generated by VVKGen. Edits to this file will be lost on next generation.

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace Vk.NVX
{

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct PhysicalDeviceMultiviewPerViewAttributesProperties : IEquatable<PhysicalDeviceMultiviewPerViewAttributesProperties>
{
	public const Vk.StructureType TYPE = Vk.StructureType.PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.Bool32 PerViewPositionAllComponents;

	public readonly override bool Equals(object? obj) => (obj is PhysicalDeviceMultiviewPerViewAttributesProperties o) && (this == o);
	readonly bool IEquatable<PhysicalDeviceMultiviewPerViewAttributesProperties>.Equals(PhysicalDeviceMultiviewPerViewAttributesProperties obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<PhysicalDeviceMultiviewPerViewAttributesProperties>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in PhysicalDeviceMultiviewPerViewAttributesProperties l, in PhysicalDeviceMultiviewPerViewAttributesProperties r)
	{
		fixed (PhysicalDeviceMultiviewPerViewAttributesProperties* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<PhysicalDeviceMultiviewPerViewAttributesProperties>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<PhysicalDeviceMultiviewPerViewAttributesProperties>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in PhysicalDeviceMultiviewPerViewAttributesProperties l, in PhysicalDeviceMultiviewPerViewAttributesProperties r)
	{
		fixed (PhysicalDeviceMultiviewPerViewAttributesProperties* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<PhysicalDeviceMultiviewPerViewAttributesProperties>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<PhysicalDeviceMultiviewPerViewAttributesProperties>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new PhysicalDeviceMultiviewPerViewAttributesProperties value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out PhysicalDeviceMultiviewPerViewAttributesProperties value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref PhysicalDeviceMultiviewPerViewAttributesProperties value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ImageViewHandleInfo : IEquatable<ImageViewHandleInfo>
{
	public const Vk.StructureType TYPE = Vk.StructureType.ImageViewHandleInfoNVX;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.ImageView ImageView;
	public Vk.DescriptorType DescriptorType;
	public Vk.Sampler Sampler;

	public readonly override bool Equals(object? obj) => (obj is ImageViewHandleInfo o) && (this == o);
	readonly bool IEquatable<ImageViewHandleInfo>.Equals(ImageViewHandleInfo obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<ImageViewHandleInfo>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in ImageViewHandleInfo l, in ImageViewHandleInfo r)
	{
		fixed (ImageViewHandleInfo* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<ImageViewHandleInfo>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<ImageViewHandleInfo>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in ImageViewHandleInfo l, in ImageViewHandleInfo r)
	{
		fixed (ImageViewHandleInfo* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<ImageViewHandleInfo>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<ImageViewHandleInfo>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new ImageViewHandleInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out ImageViewHandleInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref ImageViewHandleInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ImageViewAddressProperties : IEquatable<ImageViewAddressProperties>
{
	public const Vk.StructureType TYPE = Vk.StructureType.ImageViewAddressPropertiesNVX;

	public Vk.StructureType sType;
	public void* pNext;
	public ulong DeviceAddress;
	public Vk.DeviceSize Size;

	public readonly override bool Equals(object? obj) => (obj is ImageViewAddressProperties o) && (this == o);
	readonly bool IEquatable<ImageViewAddressProperties>.Equals(ImageViewAddressProperties obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<ImageViewAddressProperties>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in ImageViewAddressProperties l, in ImageViewAddressProperties r)
	{
		fixed (ImageViewAddressProperties* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<ImageViewAddressProperties>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<ImageViewAddressProperties>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in ImageViewAddressProperties l, in ImageViewAddressProperties r)
	{
		fixed (ImageViewAddressProperties* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<ImageViewAddressProperties>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<ImageViewAddressProperties>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new ImageViewAddressProperties value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out ImageViewAddressProperties value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref ImageViewAddressProperties value) { value.sType = TYPE; value.pNext = null; }
}

} // namespace Vk.NVX
