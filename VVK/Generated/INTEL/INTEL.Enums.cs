﻿/*
 * MIT License - Copyright(c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at<https://opensource.org/licenses/MIT>.
 */

/// This file was generated by VVKGen. Edits to this file will be lost on next generation.

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace Vk.INTEL
{

public enum PerformanceConfigurationType : int
{
	CommandQueueMetricsDiscoveryActivatedINTEL = 0,
}

public enum QueryPoolSamplingMode : int
{
	ManualINTEL = 0,
}

public enum PerformanceOverrideType : int
{
	NullHardwareINTEL = 0,
	FlushGpuCachesINTEL = 1,
}

public enum PerformanceParameterType : int
{
	HwCountersSupportedINTEL = 0,
	StreamMarkerValidBitsINTEL = 1,
}

public enum PerformanceValueType : int
{
	Uint32INTEL = 0,
	Uint64INTEL = 1,
	FloatINTEL = 2,
	BoolINTEL = 3,
	StringINTEL = 4,
}

} // namespace Vk.INTEL
