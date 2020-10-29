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
	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public readonly override int GetHashCode()
	{
		return
			Consumer.GetHashCode() ^ Producer.GetHashCode()
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator == (in NativeBufferUsage2 l, in NativeBufferUsage2 r)
	{
		return
			(l.Consumer == r.Consumer) && (l.Producer == r.Producer)
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator != (in NativeBufferUsage2 l, in NativeBufferUsage2 r)
	{
		return
			(l.Consumer != r.Consumer) || (l.Producer != r.Producer)
			;
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
	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public readonly override int GetHashCode()
	{
		return
			sType.GetHashCode() ^ ((ulong)pNext).GetHashCode() ^ ((ulong)Buffer).GetHashCode()
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator == (in ImportAndroidHardwareBufferInfo l, in ImportAndroidHardwareBufferInfo r)
	{
		return
			(l.sType == r.sType) && (l.pNext == r.pNext) && (l.Buffer == r.Buffer)
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator != (in ImportAndroidHardwareBufferInfo l, in ImportAndroidHardwareBufferInfo r)
	{
		return
			(l.sType != r.sType) || (l.pNext != r.pNext) || (l.Buffer != r.Buffer)
			;
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
	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public readonly override int GetHashCode()
	{
		return
			sType.GetHashCode() ^ ((ulong)pNext).GetHashCode() ^ AndroidHardwareBufferUsage_.GetHashCode()
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator == (in AndroidHardwareBufferUsage l, in AndroidHardwareBufferUsage r)
	{
		return
			(l.sType == r.sType) && (l.pNext == r.pNext) && (l.AndroidHardwareBufferUsage_ == r.AndroidHardwareBufferUsage_)
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator != (in AndroidHardwareBufferUsage l, in AndroidHardwareBufferUsage r)
	{
		return
			(l.sType != r.sType) || (l.pNext != r.pNext) || (l.AndroidHardwareBufferUsage_ != r.AndroidHardwareBufferUsage_)
			;
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
	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public readonly override int GetHashCode()
	{
		return
			sType.GetHashCode() ^ ((ulong)pNext).GetHashCode() ^ AllocationSize.GetHashCode() ^ MemoryTypeBits.GetHashCode()
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator == (in AndroidHardwareBufferProperties l, in AndroidHardwareBufferProperties r)
	{
		return
			(l.sType == r.sType) && (l.pNext == r.pNext) && (l.AllocationSize == r.AllocationSize) && (l.MemoryTypeBits == r.MemoryTypeBits)
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator != (in AndroidHardwareBufferProperties l, in AndroidHardwareBufferProperties r)
	{
		return
			(l.sType != r.sType) || (l.pNext != r.pNext) || (l.AllocationSize != r.AllocationSize) || (l.MemoryTypeBits != r.MemoryTypeBits)
			;
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
	public Vk.Handle<Vk.DeviceMemory> Memory;

	public readonly override bool Equals(object? obj) => (obj is MemoryGetAndroidHardwareBufferInfo o) && (this == o);
	readonly bool IEquatable<MemoryGetAndroidHardwareBufferInfo>.Equals(MemoryGetAndroidHardwareBufferInfo obj) => (this == obj);
	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public readonly override int GetHashCode()
	{
		return
			sType.GetHashCode() ^ ((ulong)pNext).GetHashCode() ^ Memory.GetHashCode()
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator == (in MemoryGetAndroidHardwareBufferInfo l, in MemoryGetAndroidHardwareBufferInfo r)
	{
		return
			(l.sType == r.sType) && (l.pNext == r.pNext) && (l.Memory == r.Memory)
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator != (in MemoryGetAndroidHardwareBufferInfo l, in MemoryGetAndroidHardwareBufferInfo r)
	{
		return
			(l.sType != r.sType) || (l.pNext != r.pNext) || (l.Memory != r.Memory)
			;
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
	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public readonly override int GetHashCode()
	{
		return
			sType.GetHashCode() ^ ((ulong)pNext).GetHashCode() ^ Format.GetHashCode() ^ ExternalFormat.GetHashCode()
			^ FormatFeatures.GetHashCode() ^ SamplerYcbcrConversionComponents.GetHashCode() ^ SuggestedYcbcrModel.GetHashCode() ^ SuggestedYcbcrRange.GetHashCode()
			^ SuggestedXChromaOffset.GetHashCode() ^ SuggestedYChromaOffset.GetHashCode()
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator == (in AndroidHardwareBufferFormatProperties l, in AndroidHardwareBufferFormatProperties r)
	{
		return
			(l.sType == r.sType) && (l.pNext == r.pNext) && (l.Format == r.Format) && (l.ExternalFormat == r.ExternalFormat)
			&& (l.FormatFeatures == r.FormatFeatures) && (l.SamplerYcbcrConversionComponents == r.SamplerYcbcrConversionComponents) && (l.SuggestedYcbcrModel == r.SuggestedYcbcrModel) && (l.SuggestedYcbcrRange == r.SuggestedYcbcrRange)
			&& (l.SuggestedXChromaOffset == r.SuggestedXChromaOffset) && (l.SuggestedYChromaOffset == r.SuggestedYChromaOffset)
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator != (in AndroidHardwareBufferFormatProperties l, in AndroidHardwareBufferFormatProperties r)
	{
		return
			(l.sType != r.sType) || (l.pNext != r.pNext) || (l.Format != r.Format) || (l.ExternalFormat != r.ExternalFormat)
			|| (l.FormatFeatures != r.FormatFeatures) || (l.SamplerYcbcrConversionComponents != r.SamplerYcbcrConversionComponents) || (l.SuggestedYcbcrModel != r.SuggestedYcbcrModel) || (l.SuggestedYcbcrRange != r.SuggestedYcbcrRange)
			|| (l.SuggestedXChromaOffset != r.SuggestedXChromaOffset) || (l.SuggestedYChromaOffset != r.SuggestedYChromaOffset)
			;
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
	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public readonly override int GetHashCode()
	{
		return
			sType.GetHashCode() ^ ((ulong)pNext).GetHashCode() ^ ExternalFormat_.GetHashCode()
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator == (in ExternalFormat l, in ExternalFormat r)
	{
		return
			(l.sType == r.sType) && (l.pNext == r.pNext) && (l.ExternalFormat_ == r.ExternalFormat_)
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator != (in ExternalFormat l, in ExternalFormat r)
	{
		return
			(l.sType != r.sType) || (l.pNext != r.pNext) || (l.ExternalFormat_ != r.ExternalFormat_)
			;
	}


	/// <summary>Creates a new ExternalFormat value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out ExternalFormat value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref ExternalFormat value) { value.sType = TYPE; value.pNext = null; }
}

} // namespace Vk.ANDROID
