﻿/*
 * MIT License - Copyright(c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at<https://opensource.org/licenses/MIT>.
 */

/// This file was generated by VVKGen. Edits to this file will be lost on next generation.

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace Vk.FUCHSIA
{

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ImagePipeSurfaceCreateInfo : IEquatable<ImagePipeSurfaceCreateInfo>
{
	public const Vk.StructureType TYPE = Vk.StructureType.ImagepipeSurfaceCreateInfoFUCHSIA;

	public Vk.StructureType sType;
	public void* pNext;
	public Vk.FUCHSIA.ImagePipeSurfaceCreateFlags Flags;
	public uint ImagePipeHandle;

	public readonly override bool Equals(object? obj) => (obj is ImagePipeSurfaceCreateInfo o) && (this == o);
	readonly bool IEquatable<ImagePipeSurfaceCreateInfo>.Equals(ImagePipeSurfaceCreateInfo obj) => (this == obj);
	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public readonly override int GetHashCode()
	{
		return
			sType.GetHashCode() ^ ((ulong)pNext).GetHashCode() ^ Flags.GetHashCode() ^ ImagePipeHandle.GetHashCode()
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator == (in ImagePipeSurfaceCreateInfo l, in ImagePipeSurfaceCreateInfo r)
	{
		return
			(l.sType == r.sType) && (l.pNext == r.pNext) && (l.Flags == r.Flags) && (l.ImagePipeHandle == r.ImagePipeHandle)
			;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static bool operator != (in ImagePipeSurfaceCreateInfo l, in ImagePipeSurfaceCreateInfo r)
	{
		return
			(l.sType != r.sType) || (l.pNext != r.pNext) || (l.Flags != r.Flags) || (l.ImagePipeHandle != r.ImagePipeHandle)
			;
	}


	/// <summary>Creates a new ImagePipeSurfaceCreateInfo value with the correct default fields.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void New(out ImagePipeSurfaceCreateInfo value) => value = new() { sType = TYPE };
}

} // namespace Vk.FUCHSIA
