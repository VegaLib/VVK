﻿/*
 * MIT License - Copyright(c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at<https://opensource.org/licenses/MIT>.
 */

/// This file was generated by VVKGen. Edits to this file will be lost on next generation.

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace VVK.Vk.INTEL
{

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct PhysicalDeviceShaderIntegerFunctions2Features
{
	public const Vk.StructureType TYPE = Vk.StructureType.PhysicalDeviceShaderIntegerFunctions2FeaturesINTEL;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.Bool32 ShaderIntegerFunctions2;

	/// <summary>Creates a new PhysicalDeviceShaderIntegerFunctions2Features value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out PhysicalDeviceShaderIntegerFunctions2Features value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref PhysicalDeviceShaderIntegerFunctions2Features value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct PerformanceValueData
{
	[FieldOffset(0)] public uint Value32;
	[FieldOffset(0)] public ulong Value64;
	[FieldOffset(0)] public float ValueFloat;
	[FieldOffset(0)] public Vk.Bool32 ValueBool;
	[FieldOffset(0)] public byte* ValueString;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct PerformanceValue
{
	public Vk.INTEL.PerformanceValueType Type;
	public Vk.INTEL.PerformanceValueData Data;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct InitializePerformanceApiInfo
{
	public const Vk.StructureType TYPE = Vk.StructureType.InitializePerformanceApiInfoINTEL;

	public Vk.StructureType sType;
	public void* pNext;
	public void* UserData;

	/// <summary>Creates a new InitializePerformanceApiInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out InitializePerformanceApiInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref InitializePerformanceApiInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct QueryPoolPerformanceQueryCreateInfo
{
	public const Vk.StructureType TYPE = Vk.StructureType.QueryPoolPerformanceQueryCreateInfoINTEL;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.INTEL.QueryPoolSamplingMode PerformanceCountersSampling;

	/// <summary>Creates a new QueryPoolPerformanceQueryCreateInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out QueryPoolPerformanceQueryCreateInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref QueryPoolPerformanceQueryCreateInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct QueryPoolCreateInfo
{
	public const Vk.StructureType TYPE = Vk.StructureType.QueryPoolPerformanceQueryCreateInfoINTEL;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.INTEL.QueryPoolSamplingMode PerformanceCountersSampling;

	/// <summary>Creates a new QueryPoolCreateInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out QueryPoolCreateInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref QueryPoolCreateInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct PerformanceMarkerInfo
{
	public const Vk.StructureType TYPE = Vk.StructureType.PerformanceMarkerInfoINTEL;

	public Vk.StructureType sType;
	public void* pNext;
	public ulong Marker;

	/// <summary>Creates a new PerformanceMarkerInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out PerformanceMarkerInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref PerformanceMarkerInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct PerformanceStreamMarkerInfo
{
	public const Vk.StructureType TYPE = Vk.StructureType.PerformanceStreamMarkerInfoINTEL;

	public Vk.StructureType sType;
	public void* pNext;
	public uint Marker;

	/// <summary>Creates a new PerformanceStreamMarkerInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out PerformanceStreamMarkerInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref PerformanceStreamMarkerInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct PerformanceOverrideInfo
{
	public const Vk.StructureType TYPE = Vk.StructureType.PerformanceOverrideInfoINTEL;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.INTEL.PerformanceOverrideType Type;
	public Vk.Bool32 Enable;
	public ulong Parameter;

	/// <summary>Creates a new PerformanceOverrideInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out PerformanceOverrideInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref PerformanceOverrideInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct PerformanceConfigurationAcquireInfo
{
	public const Vk.StructureType TYPE = Vk.StructureType.PerformanceConfigurationAcquireInfoINTEL;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.INTEL.PerformanceConfigurationType Type;

	/// <summary>Creates a new PerformanceConfigurationAcquireInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out PerformanceConfigurationAcquireInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref PerformanceConfigurationAcquireInfo value) { value.sType = TYPE; value.pNext = null; }
}

} // namespace VVK.Vk.INTEL