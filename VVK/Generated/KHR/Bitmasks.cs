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

[Flags]
public enum VkGeometryFlagsKHR : uint
{
	NoFlags = 0,
	Opaque = 1,
	NoDuplicateAnyHitInvocation = 2,
}

[Flags]
public enum VkGeometryInstanceFlagsKHR : uint
{
	NoFlags = 0,
	TriangleFacingCullDisable = 1,
	TriangleFrontCounterclockwise = 2,
	ForceOpaque = 4,
	ForceNoOpaque = 8,
	TriangleCullDisable = 1,
}

[Flags]
public enum VkBuildAccelerationStructureFlagsKHR : uint
{
	NoFlags = 0,
	AllowUpdate = 1,
	AllowCompaction = 2,
	PreferFastTrace = 4,
	PreferFastBuild = 8,
	LowMemory = 16,
}

[Flags]
public enum VkAccelerationStructureCreateFlagsKHR : uint
{
	NoFlags = 0,
	DeviceAddressCaptureReplay = 1,
}

[Flags]
public enum VkDescriptorUpdateTemplateCreateFlagsKHR : uint
{
	NoFlags = 0,
}

[Flags]
public enum VkPerformanceCounterDescriptionFlagsKHR : uint
{
	NoFlags = 0,
	PerformanceImpacting = 1,
	ConcurrentlyImpacted = 2,
}

[Flags]
public enum VkAcquireProfilingLockFlagsKHR : uint
{
	NoFlags = 0,
}

[Flags]
public enum VkSemaphoreWaitFlagsKHR : uint
{
	NoFlags = 0,
	Any = 1,
	AnyKhr = 1,
}

[Flags]
public enum VkCompositeAlphaFlagsKHR : uint
{
	NoFlags = 0,
	Opaque = 1,
	PreMultiplied = 2,
	PostMultiplied = 4,
	Inherit = 8,
}

[Flags]
public enum VkDisplayPlaneAlphaFlagsKHR : uint
{
	NoFlags = 0,
	Opaque = 1,
	Global = 2,
	PerPixel = 4,
	PerPixelPremultiplied = 8,
}

[Flags]
public enum VkSurfaceTransformFlagsKHR : uint
{
	NoFlags = 0,
	Identity = 1,
	Rotate90 = 2,
	Rotate180 = 4,
	Rotate270 = 8,
	HorizontalMirror = 16,
	HorizontalMirrorRotate90 = 32,
	HorizontalMirrorRotate180 = 64,
	HorizontalMirrorRotate270 = 128,
	Inherit = 256,
}

[Flags]
public enum VkSwapchainCreateFlagsKHR : uint
{
	NoFlags = 0,
	SplitInstanceBindRegions = 1,
	Protected = 2,
	MutableFormat = 4,
}

[Flags]
public enum VkDisplayModeCreateFlagsKHR : uint
{
	NoFlags = 0,
}

[Flags]
public enum VkDisplaySurfaceCreateFlagsKHR : uint
{
	NoFlags = 0,
}

[Flags]
public enum VkAndroidSurfaceCreateFlagsKHR : uint
{
	NoFlags = 0,
}

[Flags]
public enum VkWaylandSurfaceCreateFlagsKHR : uint
{
	NoFlags = 0,
}

[Flags]
public enum VkWin32SurfaceCreateFlagsKHR : uint
{
	NoFlags = 0,
}

[Flags]
public enum VkXlibSurfaceCreateFlagsKHR : uint
{
	NoFlags = 0,
}

[Flags]
public enum VkXcbSurfaceCreateFlagsKHR : uint
{
	NoFlags = 0,
}

[Flags]
public enum VkPeerMemoryFeatureFlagsKHR : uint
{
	NoFlags = 0,
	CopySrc = 1,
	CopyDst = 2,
	GenericSrc = 4,
	GenericDst = 8,
	CopySrcKhr = 1,
	CopyDstKhr = 2,
	GenericSrcKhr = 4,
	GenericDstKhr = 8,
}

[Flags]
public enum VkMemoryAllocateFlagsKHR : uint
{
	NoFlags = 0,
	DeviceMask = 1,
	DeviceAddress = 2,
	DeviceAddressCaptureReplay = 4,
	DeviceMaskKhr = 1,
	DeviceAddressKhr = 2,
	DeviceAddressCaptureReplayKhr = 4,
}

[Flags]
public enum VkDeviceGroupPresentModeFlagsKHR : uint
{
	NoFlags = 0,
	Local = 1,
	Remote = 2,
	Sum = 4,
	LocalMultiDevice = 8,
}

[Flags]
public enum VkCommandPoolTrimFlagsKHR : uint
{
	NoFlags = 0,
}

[Flags]
public enum VkExternalMemoryHandleTypeFlagsKHR : uint
{
	NoFlags = 0,
	OpaqueFd = 1,
	OpaqueWin32 = 2,
	OpaqueWin32Kmt = 4,
	D3d11Texture = 8,
	D3d11TextureKmt = 16,
	D3d12Heap = 32,
	D3d12Resource = 64,
	OpaqueFdKhr = 1,
	OpaqueWin32Khr = 2,
	OpaqueWin32KmtKhr = 4,
	D3d11TextureKhr = 8,
	D3d11TextureKmtKhr = 16,
	D3d12HeapKhr = 32,
	D3d12ResourceKhr = 64,
	DmaBufExt = 512,
	AndroidHardwareBufferAndroid = 1024,
	HostAllocationExt = 128,
	HostMappedForeignMemoryExt = 256,
}

[Flags]
public enum VkExternalMemoryFeatureFlagsKHR : uint
{
	NoFlags = 0,
	DedicatedOnly = 1,
	Exportable = 2,
	Importable = 4,
	DedicatedOnlyKhr = 1,
	ExportableKhr = 2,
	ImportableKhr = 4,
}

[Flags]
public enum VkExternalSemaphoreHandleTypeFlagsKHR : uint
{
	NoFlags = 0,
	OpaqueFd = 1,
	OpaqueWin32 = 2,
	OpaqueWin32Kmt = 4,
	D3d12Fence = 8,
	D3d11Fence = 8,
	SyncFd = 16,
	OpaqueFdKhr = 1,
	OpaqueWin32Khr = 2,
	OpaqueWin32KmtKhr = 4,
	D3d12FenceKhr = 8,
	SyncFdKhr = 16,
}

[Flags]
public enum VkExternalSemaphoreFeatureFlagsKHR : uint
{
	NoFlags = 0,
	Exportable = 1,
	Importable = 2,
	ExportableKhr = 1,
	ImportableKhr = 2,
}

[Flags]
public enum VkSemaphoreImportFlagsKHR : uint
{
	NoFlags = 0,
	Temporary = 1,
	TemporaryKhr = 1,
}

[Flags]
public enum VkExternalFenceHandleTypeFlagsKHR : uint
{
	NoFlags = 0,
	OpaqueFd = 1,
	OpaqueWin32 = 2,
	OpaqueWin32Kmt = 4,
	SyncFd = 8,
	OpaqueFdKhr = 1,
	OpaqueWin32Khr = 2,
	OpaqueWin32KmtKhr = 4,
	SyncFdKhr = 8,
}

[Flags]
public enum VkExternalFenceFeatureFlagsKHR : uint
{
	NoFlags = 0,
	Exportable = 1,
	Importable = 2,
	ExportableKhr = 1,
	ImportableKhr = 2,
}

[Flags]
public enum VkFenceImportFlagsKHR : uint
{
	NoFlags = 0,
	Temporary = 1,
	TemporaryKhr = 1,
}

[Flags]
public enum VkResolveModeFlagsKHR : uint
{
	NoFlags = 0,
	None = 0,
	SampleZero = 1,
	Average = 2,
	Min = 4,
	Max = 8,
	NoneKhr = 0,
	SampleZeroKhr = 1,
	AverageKhr = 2,
	MinKhr = 4,
	MaxKhr = 8,
}


} // namespace Vulkan

