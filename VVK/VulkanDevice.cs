﻿/*
 * MIT License - Copyright (c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at <https://opensource.org/licenses/MIT>.
 */

using System;
using System.Collections.Generic;
using Vk;

namespace VVK
{
	/// <summary>
	/// Wraps a VkDevice object at a higher level, providing an OOP approach to VkDevice resources and functions.
	/// </summary>
	public unsafe sealed partial class VulkanDevice : IDisposable
	{
		#region Fields
		/// <summary>
		/// The parent instance for this device.
		/// </summary>
		public VulkanInstance Instance { get; private set; }
		/// <summary>
		/// The phyiscal device that the device object was created from.
		/// </summary>
		public VulkanPhysicalDevice Parent { get; private set; }
		/// <summary>
		/// The VkInstance handle wrapped by this object.
		/// </summary>
		public Vk.Device Handle { get; private set; } = Vk.Device.Null;
		/// <summary>
		/// The API version that the device was created with.
		/// </summary>
		public readonly Vk.Version ApiVersion;
		/// <summary>
		/// The table of loaded functions for the instance.
		/// </summary>
		public Vk.DeviceFunctionTable Functions { get; private set; }

		// Cache of created queue objects (key is (family << 32 | index))
		private readonly Dictionary<ulong, VulkanQueue> _queueCache = new();
		#endregion // Fields

		/// <summary>
		/// Creates a new device wrapper from the existing device object handle.
		/// </summary>
		/// <param name="inst">The instance that the device handle was created from.</param>
		/// <param name="pdevice">The physical device that the device instance was created from.</param>
		/// <param name="device">The pre-created device handle.</param>
		/// <param name="version">The API version that the device was created with.</param>
		public VulkanDevice(VulkanInstance inst, VulkanPhysicalDevice pdevice, Vk.Device device, Vk.Version version)
		{
			Instance = inst;
			Parent = pdevice;
			Handle = device;
			ApiVersion = version;
			Functions = new(device, version);
		}
		~VulkanDevice()
		{
			dispose(false);
		}

		#region Queues
		/// <summary>
		/// Gets the device queue handle with the given family and queue index. Throws an exception if the queue was
		/// not found.
		/// </summary>
		/// <param name="family">The queue family index.</param>
		/// <param name="index">The queue index within the family.</param>
		public Vk.Queue GetQueueHandle(uint family, uint index)
		{
			Vk.Queue queue;
			GetDeviceQueue(family, index, &queue);
			if (!queue) {
				throw new ArgumentException($"There is no device queue at location [{family}:{index}]");
			}
			return queue;
		}

		/// <summary>
		/// Attempts to get the device queue with the given family and index. Returns if the queue was retreived.
		/// </summary>
		/// <param name="family">The queue family index.</param>
		/// <param name="index">The queue index within the family.</param>
		/// <param name="queue">The output handle.</param>
		public bool TryGetQueueHandle(uint family, uint index, out Vk.Queue queue)
		{
			Vk.Queue handle;
			GetDeviceQueue(family, index, &handle);
			queue = handle;
			return !!queue;
		}

		/// <summary>
		/// Gets the device queue wrapper object for the given family and index. Throws an exception if the queue was
		/// not found.
		/// </summary>
		/// <param name="family">The queue family index.</param>
		/// <param name="index">The queue index within the family.</param>
		public VulkanQueue GetQueue(uint family, uint index)
		{
			var key = ((ulong)family << 32) | index;
			if (_queueCache.TryGetValue(key, out var queue)) {
				return queue;
			}
			var handle = GetQueueHandle(family, index);
			return (_queueCache[key] = new VulkanQueue(this, handle, family, index));
		}

		/// <summary>
		/// Gets the device queue wrapper object for the given family and index. Returns if the queue was retreived.
		/// </summary>
		/// <param name="family">The queue family index.</param>
		/// <param name="index">The queue index within the family.</param>
		public bool TryGetQueue(uint family, uint index, out VulkanQueue? queue)
		{
			var key = ((ulong)family << 32) | index;
			if (_queueCache.TryGetValue(key, out queue)) {
				return true;
			}
			if (TryGetQueueHandle(family, index, out var handle)) {
				queue = (_queueCache[key] = new(this, handle, family, index));
				return true;
			}
			return false;
		}
		#endregion // Queues

		#region Command Buffers
		/// <summary>
		/// Allocates a command buffer from the pool and creates a wrapper object for it.
		/// </summary>
		/// <param name="pool">The pool to allocate the buffer from.</param>
		/// <param name="level">The level for the command buffer.</param>
		/// <param name="buffer">The generated buffer.</param>
		/// <returns>The result of allocating the buffer.</returns>
		public VulkanResult AllocateCommandBuffer(Vk.CommandPool pool, Vk.CommandBufferLevel level, 
			out VulkanCommandBuffer? buffer)
		{
			if (!pool) {
				throw new ArgumentNullException(nameof(pool), "Null command pool");
			}

			Vk.CommandBufferAllocateInfo.New(out var cbai);
			cbai.CommandBufferCount = 1;
			cbai.CommandPool = pool;
			cbai.Level = level;
			Vk.CommandBuffer handle;
			var res = AllocateCommandBuffers(&cbai, &handle);
			buffer = res ? new VulkanCommandBuffer(this, pool, handle) : null;
			return res;
		}

		/// <summary>
		/// Allocates command buffers from the pool and creates wrapper objects for them.
		/// </summary>
		/// <param name="pool">The pool to allocate the buffers from.</param>
		/// <param name="level">The level for the command buffers.</param>
		/// <param name="buffer">The generated buffers.</param>
		/// <returns>The result of allocating the buffers.</returns>
		public VulkanResult AllocateCommandBuffers(Vk.CommandPool pool, Vk.CommandBufferLevel level, uint count,
			out VulkanCommandBuffer[]? buffers)
		{
			if (!pool) {
				throw new ArgumentNullException(nameof(pool), "Null command pool");
			}

			Vk.CommandBufferAllocateInfo.New(out var cbai);
			cbai.CommandBufferCount = count;
			cbai.CommandPool = pool;
			cbai.Level = level;
			var handles = stackalloc Vk.CommandBuffer[(int)count];
			var res = AllocateCommandBuffers(&cbai, handles);
			if (res) {
				buffers = new VulkanCommandBuffer[count];
				for (uint i = 0; i < count; ++i) {
					buffers[i] = new VulkanCommandBuffer(this, pool, handles[i]);
				}
			}
			else buffers = null;

			return res;
		}
		#endregion // Command Buffers

		#region IDisposable
		/// <summary>
		/// If this represents a valid instance handle, this will destroy the instance object and free resources.
		/// </summary>
		public void Dispose()
		{
			dispose(true);
			GC.SuppressFinalize(this);
		}

		private void dispose(bool disposing)
		{
			if (Handle) {
				WaitIdle();
				DestroyDevice(null);
			}
			Handle = Vk.Device.Null;
			Functions = new();
		}
		#endregion // IDisposable
	}
}
