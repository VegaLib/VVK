﻿/*
 * MIT License - Copyright(c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at<https://opensource.org/licenses/MIT>.
 */

/// This file was generated by VVKGen. Edits to this file will be lost on next generation.

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace VVK.Vk.ANDROID
{

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct NativeBufferUsage2
{
	public ulong Consumer;
	public ulong Producer;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ImportAndroidHardwareBufferInfo
{
	public const Vk.StructureType TYPE = Vk.StructureType.ImportAndroidHardwareBufferInfoANDROID;

	public Vk.StructureType sType;
	public void* pNext;
	public void* Buffer;

	/// <summary>Creates a new ImportAndroidHardwareBufferInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out ImportAndroidHardwareBufferInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref ImportAndroidHardwareBufferInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct AndroidHardwareBufferUsage
{
	public const Vk.StructureType TYPE = Vk.StructureType.AndroidHardwareBufferUsageANDROID;

	public Vk.StructureType sType;
	public void* pNext;
	public ulong AndroidHardwareBufferUsage_;

	/// <summary>Creates a new AndroidHardwareBufferUsage value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out AndroidHardwareBufferUsage value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref AndroidHardwareBufferUsage value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct AndroidHardwareBufferProperties
{
	public const Vk.StructureType TYPE = Vk.StructureType.AndroidHardwareBufferPropertiesANDROID;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.DeviceSize AllocationSize;
	public uint MemoryTypeBits;

	/// <summary>Creates a new AndroidHardwareBufferProperties value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out AndroidHardwareBufferProperties value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref AndroidHardwareBufferProperties value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct MemoryGetAndroidHardwareBufferInfo
{
	public const Vk.StructureType TYPE = Vk.StructureType.MemoryGetAndroidHardwareBufferInfoANDROID;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.DeviceMemory Memory;

	/// <summary>Creates a new MemoryGetAndroidHardwareBufferInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out MemoryGetAndroidHardwareBufferInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref MemoryGetAndroidHardwareBufferInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct AndroidHardwareBufferFormatProperties
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

	/// <summary>Creates a new AndroidHardwareBufferFormatProperties value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out AndroidHardwareBufferFormatProperties value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref AndroidHardwareBufferFormatProperties value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ExternalFormat
{
	public const Vk.StructureType TYPE = Vk.StructureType.ExternalFormatANDROID;

	public Vk.StructureType sType;
	public void* pNext;
	public ulong ExternalFormat_;

	/// <summary>Creates a new ExternalFormat value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out ExternalFormat value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref ExternalFormat value) { value.sType = TYPE; value.pNext = null; }
}

} // namespace VVK.Vk.ANDROID