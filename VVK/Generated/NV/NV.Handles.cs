﻿/*
 * MIT License - Copyright(c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at<https://opensource.org/licenses/MIT>.
 */

/// This file was generated by VVKGen. Edits to this file will be lost on next generation.

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace Vk.NV
{

public unsafe partial class IndirectCommandsLayout : IHandleType<IndirectCommandsLayout>
{
	public static readonly IndirectCommandsLayout Null = new(Device.Null, Vk.Handle<IndirectCommandsLayout>.Null);

	public readonly Vk.Device Parent;
	public readonly Vk.DeviceFunctionTable Functions;
	public readonly Vk.Instance Instance;
	public readonly Vk.Device Device;
	public readonly Handle<IndirectCommandsLayout> Handle;
	public bool IsValid => Handle.IsValid;

	public IndirectCommandsLayout(in Vk.Device parent, Vk.Handle<IndirectCommandsLayout> handle)
	{
		Parent = parent;
		Functions = parent.Functions;
		Instance = parent.Instance;
		Device = parent;
		Handle = handle;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => $"[IndirectCommandsLayout 0x{(ulong)Handle:X16}]";
	public override bool Equals(object? o) => (o is IndirectCommandsLayout t) && (t.Handle == Handle);
	bool IEquatable<IndirectCommandsLayout>.Equals(IndirectCommandsLayout? other) => (other?.Handle ?? new()) == Handle;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vk.Handle<IndirectCommandsLayout> (IndirectCommandsLayout? handle) => handle?.Handle ?? new();
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (IndirectCommandsLayout? l, IndirectCommandsLayout? r) => (l?.Handle ?? new()) == (r?.Handle ?? new());
	public static bool operator != (IndirectCommandsLayout? l, IndirectCommandsLayout? r) => (l?.Handle ?? new()) == (r?.Handle ?? new());
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator bool (IndirectCommandsLayout? handle) => handle?.Handle.IsValid ?? false;

	/// <summary>vkDestroyIndirectCommandsLayoutNV</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DestroyIndirectCommandsLayoutNV(Vk.AllocationCallbacks* pAllocator)
		=> Functions.vkDestroyIndirectCommandsLayoutNV(Device.Handle, Handle, pAllocator);

	/// <summary>vkDestroyIndirectCommandsLayoutNV</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DestroyIndirectCommandsLayoutNV(in Vk.AllocationCallbacks allocator)
		=> Functions.DestroyIndirectCommandsLayoutNV(Device.Handle, Handle, allocator);

}

public unsafe partial class AccelerationStructure : IHandleType<AccelerationStructure>
{
	public static readonly AccelerationStructure Null = new(Device.Null, Vk.Handle<AccelerationStructure>.Null);

	public readonly Vk.Device Parent;
	public readonly Vk.DeviceFunctionTable Functions;
	public readonly Vk.Instance Instance;
	public readonly Vk.Device Device;
	public readonly Handle<AccelerationStructure> Handle;
	public bool IsValid => Handle.IsValid;

	public AccelerationStructure(in Vk.Device parent, Vk.Handle<AccelerationStructure> handle)
	{
		Parent = parent;
		Functions = parent.Functions;
		Instance = parent.Instance;
		Device = parent;
		Handle = handle;
	}

	public override int GetHashCode() => Handle.GetHashCode();
	public override string? ToString() => $"[AccelerationStructure 0x{(ulong)Handle:X16}]";
	public override bool Equals(object? o) => (o is AccelerationStructure t) && (t.Handle == Handle);
	bool IEquatable<AccelerationStructure>.Equals(AccelerationStructure? other) => (other?.Handle ?? new()) == Handle;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vk.Handle<AccelerationStructure> (AccelerationStructure? handle) => handle?.Handle ?? new();
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator == (AccelerationStructure? l, AccelerationStructure? r) => (l?.Handle ?? new()) == (r?.Handle ?? new());
	public static bool operator != (AccelerationStructure? l, AccelerationStructure? r) => (l?.Handle ?? new()) == (r?.Handle ?? new());
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator bool (AccelerationStructure? handle) => handle?.Handle.IsValid ?? false;

}

} // namespace Vk.NV
