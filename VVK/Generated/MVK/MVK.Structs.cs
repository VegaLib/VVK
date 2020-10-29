﻿/*
 * MIT License - Copyright(c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at<https://opensource.org/licenses/MIT>.
 */

/// This file was generated by VVKGen. Edits to this file will be lost on next generation.

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace Vk.MVK
{

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct IOSSurfaceCreateInfo : IEquatable<IOSSurfaceCreateInfo>
{
	public const Vk.StructureType TYPE = Vk.StructureType.IosSurfaceCreateInfoMVK;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.MVK.IOSSurfaceCreateFlags Flags;
	public void* View;

	public readonly override bool Equals(object? obj) => (obj is IOSSurfaceCreateInfo o) && (this == o);
	readonly bool IEquatable<IOSSurfaceCreateInfo>.Equals(IOSSurfaceCreateInfo obj) => (this == obj);
	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public readonly override int GetHashCode()
	{
		return
			sType.GetHashCode() ^ ((ulong)pNext).GetHashCode() ^ Flags.GetHashCode() ^ ((ulong)View).GetHashCode()
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator == (in IOSSurfaceCreateInfo l, in IOSSurfaceCreateInfo r)
	{
		return
			(l.sType == r.sType) && (l.pNext == r.pNext) && (l.Flags == r.Flags) && (l.View == r.View)
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator != (in IOSSurfaceCreateInfo l, in IOSSurfaceCreateInfo r)
	{
		return
			(l.sType != r.sType) || (l.pNext != r.pNext) || (l.Flags != r.Flags) || (l.View != r.View)
			;
	}


	/// <summary>Creates a new IOSSurfaceCreateInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out IOSSurfaceCreateInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref IOSSurfaceCreateInfo value) { value.sType = TYPE; value.pNext = null; }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct MacOSSurfaceCreateInfo : IEquatable<MacOSSurfaceCreateInfo>
{
	public const Vk.StructureType TYPE = Vk.StructureType.MacosSurfaceCreateInfoMVK;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.MVK.MacOSSurfaceCreateFlags Flags;
	public void* View;

	public readonly override bool Equals(object? obj) => (obj is MacOSSurfaceCreateInfo o) && (this == o);
	readonly bool IEquatable<MacOSSurfaceCreateInfo>.Equals(MacOSSurfaceCreateInfo obj) => (this == obj);
	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public readonly override int GetHashCode()
	{
		return
			sType.GetHashCode() ^ ((ulong)pNext).GetHashCode() ^ Flags.GetHashCode() ^ ((ulong)View).GetHashCode()
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator == (in MacOSSurfaceCreateInfo l, in MacOSSurfaceCreateInfo r)
	{
		return
			(l.sType == r.sType) && (l.pNext == r.pNext) && (l.Flags == r.Flags) && (l.View == r.View)
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator != (in MacOSSurfaceCreateInfo l, in MacOSSurfaceCreateInfo r)
	{
		return
			(l.sType != r.sType) || (l.pNext != r.pNext) || (l.Flags != r.Flags) || (l.View != r.View)
			;
	}


	/// <summary>Creates a new MacOSSurfaceCreateInfo value with the correct type field.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out MacOSSurfaceCreateInfo value) => value = new() { sType = TYPE };
	/// <summary>Initializes the sType and pNext fields to the correct default values.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Init(ref MacOSSurfaceCreateInfo value) { value.sType = TYPE; value.pNext = null; }
}

} // namespace Vk.MVK
