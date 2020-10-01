﻿/*
 * MIT License - Copyright (c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at <https://opensource.org/licenses/MIT>.
 */

using System;

namespace VVK
{
	/// <summary>
	/// Wraps a VkCommandBuffer object at a higher level, providing an OOP approach to VkCommandBuffer resources and
	/// functions.
	/// </summary>
	public unsafe sealed partial class VulkanCommandBuffer
	{
		#region Fields
		/// <summary>
		/// The parent device that owns this command buffer.
		/// </summary>
		public readonly VulkanDevice Parent;
		/// <summary>
		/// The API handle for this command buffer.
		/// </summary>
		public readonly Vk.CommandBuffer Handle;
		#endregion // Fields

		/// <summary>
		/// Creates a new command buffer wrapper from an existing device and command buffer handle.
		/// </summary>
		/// <param name="parent">The device that owns the command buffer.</param>
		/// <param name="handle">The existing command buffer handle.</param>
		public VulkanCommandBuffer(VulkanDevice parent, Vk.CommandBuffer handle)
		{
			Parent = parent.Handle ? parent : throw new ArgumentNullException(nameof(parent), "Null parent device");
			Handle = handle ? handle : throw new ArgumentNullException(nameof(handle), "Null command buffer handle");
		}
	}
}