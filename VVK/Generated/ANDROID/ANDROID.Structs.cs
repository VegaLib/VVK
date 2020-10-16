﻿/*
 * MIT License - Copyright(c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at<https://opensource.org/licenses/MIT>.
 */

/// This file was generated by VVKGen. Edits to this file will be lost on next generation.

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace Vk.ANDROID
{

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct NativeBufferUsage2 : IEquatable<NativeBufferUsage2>
{
	public ulong Consumer;
	public ulong Producer;

	public readonly override bool Equals(object? obj) => (obj is NativeBufferUsage2 o) && (this == o);
	readonly bool IEquatable<NativeBufferUsage2>.Equals(NativeBufferUsage2 obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (ulong* ptr = &Consumer) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<NativeBufferUsage2>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in NativeBufferUsage2 l, in NativeBufferUsage2 r)
	{
		fixed (NativeBufferUsage2* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<NativeBufferUsage2>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<NativeBufferUsage2>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in NativeBufferUsage2 l, in NativeBufferUsage2 r)
	{
		fixed (NativeBufferUsage2* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<NativeBufferUsage2>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<NativeBufferUsage2>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}

}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ImportAndroidHardwareBufferInfo : IEquatable<ImportAndroidHardwareBufferInfo>
{
	public const Vk.StructureType TYPE = Vk.StructureType.ImportAndroidHardwareBufferInfoANDROID;

	public Vk.StructureType sType;
	public void* pNext;
	public void* Buffer;

	public readonly override bool Equals(object? obj) => (obj is ImportAndroidHardwareBufferInfo o) && (this == o);
	readonly bool IEquatable<ImportAndroidHardwareBufferInfo>.Equals(ImportAndroidHardwareBufferInfo obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<ImportAndroidHardwareBufferInfo>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in ImportAndroidHardwareBufferInfo l, in ImportAndroidHardwareBufferInfo r)
	{
		fixed (ImportAndroidHardwareBufferInfo* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<ImportAndroidHardwareBufferInfo>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<ImportAndroidHardwareBufferInfo>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in ImportAndroidHardwareBufferInfo l, in ImportAndroidHardwareBufferInfo r)
	{
		fixed (ImportAndroidHardwareBufferInfo* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<ImportAndroidHardwareBufferInfo>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<ImportAndroidHardwareBufferInfo>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new ImportAndroidHardwareBufferInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out ImportAndroidHardwareBufferInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref ImportAndroidHardwareBufferInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct AndroidHardwareBufferUsage : IEquatable<AndroidHardwareBufferUsage>
{
	public const Vk.StructureType TYPE = Vk.StructureType.AndroidHardwareBufferUsageANDROID;

	public Vk.StructureType sType;
	public void* pNext;
	public ulong AndroidHardwareBufferUsage_;

	public readonly override bool Equals(object? obj) => (obj is AndroidHardwareBufferUsage o) && (this == o);
	readonly bool IEquatable<AndroidHardwareBufferUsage>.Equals(AndroidHardwareBufferUsage obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<AndroidHardwareBufferUsage>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in AndroidHardwareBufferUsage l, in AndroidHardwareBufferUsage r)
	{
		fixed (AndroidHardwareBufferUsage* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<AndroidHardwareBufferUsage>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<AndroidHardwareBufferUsage>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in AndroidHardwareBufferUsage l, in AndroidHardwareBufferUsage r)
	{
		fixed (AndroidHardwareBufferUsage* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<AndroidHardwareBufferUsage>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<AndroidHardwareBufferUsage>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new AndroidHardwareBufferUsage value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out AndroidHardwareBufferUsage value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref AndroidHardwareBufferUsage value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct AndroidHardwareBufferProperties : IEquatable<AndroidHardwareBufferProperties>
{
	public const Vk.StructureType TYPE = Vk.StructureType.AndroidHardwareBufferPropertiesANDROID;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.DeviceSize AllocationSize;
	public uint MemoryTypeBits;

	public readonly override bool Equals(object? obj) => (obj is AndroidHardwareBufferProperties o) && (this == o);
	readonly bool IEquatable<AndroidHardwareBufferProperties>.Equals(AndroidHardwareBufferProperties obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<AndroidHardwareBufferProperties>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in AndroidHardwareBufferProperties l, in AndroidHardwareBufferProperties r)
	{
		fixed (AndroidHardwareBufferProperties* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<AndroidHardwareBufferProperties>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<AndroidHardwareBufferProperties>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in AndroidHardwareBufferProperties l, in AndroidHardwareBufferProperties r)
	{
		fixed (AndroidHardwareBufferProperties* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<AndroidHardwareBufferProperties>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<AndroidHardwareBufferProperties>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new AndroidHardwareBufferProperties value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out AndroidHardwareBufferProperties value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref AndroidHardwareBufferProperties value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct MemoryGetAndroidHardwareBufferInfo : IEquatable<MemoryGetAndroidHardwareBufferInfo>
{
	public const Vk.StructureType TYPE = Vk.StructureType.MemoryGetAndroidHardwareBufferInfoANDROID;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.DeviceMemory Memory;

	public readonly override bool Equals(object? obj) => (obj is MemoryGetAndroidHardwareBufferInfo o) && (this == o);
	readonly bool IEquatable<MemoryGetAndroidHardwareBufferInfo>.Equals(MemoryGetAndroidHardwareBufferInfo obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<MemoryGetAndroidHardwareBufferInfo>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in MemoryGetAndroidHardwareBufferInfo l, in MemoryGetAndroidHardwareBufferInfo r)
	{
		fixed (MemoryGetAndroidHardwareBufferInfo* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<MemoryGetAndroidHardwareBufferInfo>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<MemoryGetAndroidHardwareBufferInfo>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in MemoryGetAndroidHardwareBufferInfo l, in MemoryGetAndroidHardwareBufferInfo r)
	{
		fixed (MemoryGetAndroidHardwareBufferInfo* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<MemoryGetAndroidHardwareBufferInfo>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<MemoryGetAndroidHardwareBufferInfo>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new MemoryGetAndroidHardwareBufferInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out MemoryGetAndroidHardwareBufferInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref MemoryGetAndroidHardwareBufferInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct AndroidHardwareBufferFormatProperties : IEquatable<AndroidHardwareBufferFormatProperties>
{
	public const Vk.StructureType TYPE = Vk.StructureType.AndroidHardwareBufferFormatPropertiesANDROID;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.Format Format;
	public ulong ExternalFormat;
	public Vk.FormatFeatureFlags FormatFeatures;
	public Vk.ComponentMapping SamplerYcbcrConversionComponents;
	public Vk.SamplerYcbcrModelConversion SuggestedYcbcrModel;
	public Vk.SamplerYcbcrRange SuggestedYcbcrRange;
	public Vk.ChromaLocation SuggestedXChromaOffset;
	public Vk.ChromaLocation SuggestedYChromaOffset;

	public readonly override bool Equals(object? obj) => (obj is AndroidHardwareBufferFormatProperties o) && (this == o);
	readonly bool IEquatable<AndroidHardwareBufferFormatProperties>.Equals(AndroidHardwareBufferFormatProperties obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<AndroidHardwareBufferFormatProperties>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in AndroidHardwareBufferFormatProperties l, in AndroidHardwareBufferFormatProperties r)
	{
		fixed (AndroidHardwareBufferFormatProperties* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<AndroidHardwareBufferFormatProperties>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<AndroidHardwareBufferFormatProperties>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in AndroidHardwareBufferFormatProperties l, in AndroidHardwareBufferFormatProperties r)
	{
		fixed (AndroidHardwareBufferFormatProperties* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<AndroidHardwareBufferFormatProperties>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<AndroidHardwareBufferFormatProperties>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new AndroidHardwareBufferFormatProperties value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out AndroidHardwareBufferFormatProperties value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref AndroidHardwareBufferFormatProperties value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ExternalFormat : IEquatable<ExternalFormat>
{
	public const Vk.StructureType TYPE = Vk.StructureType.ExternalFormatANDROID;

	public Vk.StructureType sType;
	public void* pNext;
	public ulong ExternalFormat_;

	public readonly override bool Equals(object? obj) => (obj is ExternalFormat o) && (this == o);
	readonly bool IEquatable<ExternalFormat>.Equals(ExternalFormat obj) => (this == obj);
	public readonly override int GetHashCode()
	{
		fixed (Vk.StructureType* ptr = &sType) {
			return VVK.Hasher.HashBytes(ptr, (uint)Unsafe.SizeOf<ExternalFormat>());
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (in ExternalFormat l, in ExternalFormat r)
	{
		fixed (ExternalFormat* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<ExternalFormat>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<ExternalFormat>());
			return lb.SequenceCompareTo(rb) == 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator != (in ExternalFormat l, in ExternalFormat r)
	{
		fixed (ExternalFormat* lp = &l, rp = &r) {
			ReadOnlySpan<byte> lb = new((byte*)lp, Unsafe.SizeOf<ExternalFormat>());
			ReadOnlySpan<byte> rb = new((byte*)rp, Unsafe.SizeOf<ExternalFormat>());
			return lb.SequenceCompareTo(rb) != 0;
		}
	}


	/// <summary>Creates a new ExternalFormat value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out ExternalFormat value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref ExternalFormat value) { value.sType = TYPE; value.pNext = null; }
}

} // namespace Vk.ANDROID
