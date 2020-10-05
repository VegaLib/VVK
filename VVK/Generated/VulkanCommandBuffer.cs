﻿/*
 * MIT License - Copyright(c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at<https://opensource.org/licenses/MIT>.
 */

/// This file was generated by VVKGen. Edits to this file will be lost on next generation.

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace VVK
{

public unsafe sealed partial class VulkanCommandBuffer
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public VulkanResult BeginCommandBuffer(Vk.CommandBufferBeginInfo* pBeginInfo)
		=> new(Parent.Functions.vkBeginCommandBuffer(Handle, pBeginInfo), "vkBeginCommandBuffer");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public VulkanResult EndCommandBuffer()
		=> new(Parent.Functions.vkEndCommandBuffer(Handle), "vkEndCommandBuffer");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public VulkanResult ResetCommandBuffer(Vk.CommandBufferResetFlags flags)
		=> new(Parent.Functions.vkResetCommandBuffer(Handle, flags), "vkResetCommandBuffer");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BindPipeline(Vk.PipelineBindPoint pipelineBindPoint, Vk.Pipeline pipeline)
		=> Parent.Functions.vkCmdBindPipeline(Handle, pipelineBindPoint, pipeline);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetViewport(uint firstViewport, uint viewportCount, Vk.Viewport* pViewports)
		=> Parent.Functions.vkCmdSetViewport(Handle, firstViewport, viewportCount, pViewports);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetScissor(uint firstScissor, uint scissorCount, Vk.Rect2D* pScissors)
		=> Parent.Functions.vkCmdSetScissor(Handle, firstScissor, scissorCount, pScissors);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetLineWidth(float lineWidth)
		=> Parent.Functions.vkCmdSetLineWidth(Handle, lineWidth);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetDepthBias(float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
		=> Parent.Functions.vkCmdSetDepthBias(Handle, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetBlendConstants(float* blendConstants)
		=> Parent.Functions.vkCmdSetBlendConstants(Handle, blendConstants);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetDepthBounds(float minDepthBounds, float maxDepthBounds)
		=> Parent.Functions.vkCmdSetDepthBounds(Handle, minDepthBounds, maxDepthBounds);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetStencilCompareMask(Vk.StencilFaceFlags faceMask, uint compareMask)
		=> Parent.Functions.vkCmdSetStencilCompareMask(Handle, faceMask, compareMask);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetStencilWriteMask(Vk.StencilFaceFlags faceMask, uint writeMask)
		=> Parent.Functions.vkCmdSetStencilWriteMask(Handle, faceMask, writeMask);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetStencilReference(Vk.StencilFaceFlags faceMask, uint reference)
		=> Parent.Functions.vkCmdSetStencilReference(Handle, faceMask, reference);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BindDescriptorSets(Vk.PipelineBindPoint pipelineBindPoint, Vk.PipelineLayout layout, uint firstSet, uint descriptorSetCount, Vk.DescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets)
		=> Parent.Functions.vkCmdBindDescriptorSets(Handle, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BindIndexBuffer(Vk.Buffer buffer, Vk.DeviceSize offset, Vk.IndexType indexType)
		=> Parent.Functions.vkCmdBindIndexBuffer(Handle, buffer, offset, indexType);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BindVertexBuffers(uint firstBinding, uint bindingCount, Vk.Buffer* pBuffers, Vk.DeviceSize* pOffsets)
		=> Parent.Functions.vkCmdBindVertexBuffers(Handle, firstBinding, bindingCount, pBuffers, pOffsets);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Draw(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
		=> Parent.Functions.vkCmdDraw(Handle, vertexCount, instanceCount, firstVertex, firstInstance);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DrawIndexed(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
		=> Parent.Functions.vkCmdDrawIndexed(Handle, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DrawIndirect(Vk.Buffer buffer, Vk.DeviceSize offset, uint drawCount, uint stride)
		=> Parent.Functions.vkCmdDrawIndirect(Handle, buffer, offset, drawCount, stride);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DrawIndexedIndirect(Vk.Buffer buffer, Vk.DeviceSize offset, uint drawCount, uint stride)
		=> Parent.Functions.vkCmdDrawIndexedIndirect(Handle, buffer, offset, drawCount, stride);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Dispatch(uint groupCountX, uint groupCountY, uint groupCountZ)
		=> Parent.Functions.vkCmdDispatch(Handle, groupCountX, groupCountY, groupCountZ);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DispatchIndirect(Vk.Buffer buffer, Vk.DeviceSize offset)
		=> Parent.Functions.vkCmdDispatchIndirect(Handle, buffer, offset);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void CopyBuffer(Vk.Buffer srcBuffer, Vk.Buffer dstBuffer, uint regionCount, Vk.BufferCopy* pRegions)
		=> Parent.Functions.vkCmdCopyBuffer(Handle, srcBuffer, dstBuffer, regionCount, pRegions);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void CopyImage(Vk.Image srcImage, Vk.ImageLayout srcImageLayout, Vk.Image dstImage, Vk.ImageLayout dstImageLayout, uint regionCount, Vk.ImageCopy* pRegions)
		=> Parent.Functions.vkCmdCopyImage(Handle, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BlitImage(Vk.Image srcImage, Vk.ImageLayout srcImageLayout, Vk.Image dstImage, Vk.ImageLayout dstImageLayout, uint regionCount, Vk.ImageBlit* pRegions, Vk.Filter filter)
		=> Parent.Functions.vkCmdBlitImage(Handle, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void CopyBufferToImage(Vk.Buffer srcBuffer, Vk.Image dstImage, Vk.ImageLayout dstImageLayout, uint regionCount, Vk.BufferImageCopy* pRegions)
		=> Parent.Functions.vkCmdCopyBufferToImage(Handle, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void CopyImageToBuffer(Vk.Image srcImage, Vk.ImageLayout srcImageLayout, Vk.Buffer dstBuffer, uint regionCount, Vk.BufferImageCopy* pRegions)
		=> Parent.Functions.vkCmdCopyImageToBuffer(Handle, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void UpdateBuffer(Vk.Buffer dstBuffer, Vk.DeviceSize dstOffset, Vk.DeviceSize dataSize, void* pData)
		=> Parent.Functions.vkCmdUpdateBuffer(Handle, dstBuffer, dstOffset, dataSize, pData);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void FillBuffer(Vk.Buffer dstBuffer, Vk.DeviceSize dstOffset, Vk.DeviceSize size, uint data)
		=> Parent.Functions.vkCmdFillBuffer(Handle, dstBuffer, dstOffset, size, data);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void ClearColorImage(Vk.Image image, Vk.ImageLayout imageLayout, Vk.ClearColorValue* pColor, uint rangeCount, Vk.ImageSubresourceRange* pRanges)
		=> Parent.Functions.vkCmdClearColorImage(Handle, image, imageLayout, pColor, rangeCount, pRanges);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void ClearDepthStencilImage(Vk.Image image, Vk.ImageLayout imageLayout, Vk.ClearDepthStencilValue* pDepthStencil, uint rangeCount, Vk.ImageSubresourceRange* pRanges)
		=> Parent.Functions.vkCmdClearDepthStencilImage(Handle, image, imageLayout, pDepthStencil, rangeCount, pRanges);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void ClearAttachments(uint attachmentCount, Vk.ClearAttachment* pAttachments, uint rectCount, Vk.ClearRect* pRects)
		=> Parent.Functions.vkCmdClearAttachments(Handle, attachmentCount, pAttachments, rectCount, pRects);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void ResolveImage(Vk.Image srcImage, Vk.ImageLayout srcImageLayout, Vk.Image dstImage, Vk.ImageLayout dstImageLayout, uint regionCount, Vk.ImageResolve* pRegions)
		=> Parent.Functions.vkCmdResolveImage(Handle, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetEvent(Vk.Event @event, Vk.PipelineStageFlags stageMask)
		=> Parent.Functions.vkCmdSetEvent(Handle, @event, stageMask);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void ResetEvent(Vk.Event @event, Vk.PipelineStageFlags stageMask)
		=> Parent.Functions.vkCmdResetEvent(Handle, @event, stageMask);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void WaitEvents(uint eventCount, Vk.Event* pEvents, Vk.PipelineStageFlags srcStageMask, Vk.PipelineStageFlags dstStageMask, uint memoryBarrierCount, Vk.MemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, Vk.BufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, Vk.ImageMemoryBarrier* pImageMemoryBarriers)
		=> Parent.Functions.vkCmdWaitEvents(Handle, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void PipelineBarrier(Vk.PipelineStageFlags srcStageMask, Vk.PipelineStageFlags dstStageMask, Vk.DependencyFlags dependencyFlags, uint memoryBarrierCount, Vk.MemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, Vk.BufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, Vk.ImageMemoryBarrier* pImageMemoryBarriers)
		=> Parent.Functions.vkCmdPipelineBarrier(Handle, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BeginQuery(Vk.QueryPool queryPool, uint query, Vk.QueryControlFlags flags)
		=> Parent.Functions.vkCmdBeginQuery(Handle, queryPool, query, flags);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void EndQuery(Vk.QueryPool queryPool, uint query)
		=> Parent.Functions.vkCmdEndQuery(Handle, queryPool, query);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BeginConditionalRenderingEXT(Vk.EXT.ConditionalRenderingBeginInfo* pConditionalRenderingBegin)
		=> Parent.Functions.vkCmdBeginConditionalRenderingEXT(Handle, pConditionalRenderingBegin);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void EndConditionalRenderingEXT()
		=> Parent.Functions.vkCmdEndConditionalRenderingEXT(Handle);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void ResetQueryPool(Vk.QueryPool queryPool, uint firstQuery, uint queryCount)
		=> Parent.Functions.vkCmdResetQueryPool(Handle, queryPool, firstQuery, queryCount);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void WriteTimestamp(Vk.PipelineStageFlags pipelineStage, Vk.QueryPool queryPool, uint query)
		=> Parent.Functions.vkCmdWriteTimestamp(Handle, pipelineStage, queryPool, query);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void CopyQueryPoolResults(Vk.QueryPool queryPool, uint firstQuery, uint queryCount, Vk.Buffer dstBuffer, Vk.DeviceSize dstOffset, Vk.DeviceSize stride, Vk.QueryResultFlags flags)
		=> Parent.Functions.vkCmdCopyQueryPoolResults(Handle, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void PushConstants(Vk.PipelineLayout layout, Vk.ShaderStageFlags stageFlags, uint offset, uint size, void* pValues)
		=> Parent.Functions.vkCmdPushConstants(Handle, layout, stageFlags, offset, size, pValues);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BeginRenderPass(Vk.RenderPassBeginInfo* pRenderPassBegin, Vk.SubpassContents contents)
		=> Parent.Functions.vkCmdBeginRenderPass(Handle, pRenderPassBegin, contents);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void NextSubpass(Vk.SubpassContents contents)
		=> Parent.Functions.vkCmdNextSubpass(Handle, contents);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void EndRenderPass()
		=> Parent.Functions.vkCmdEndRenderPass(Handle);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void ExecuteCommands(uint commandBufferCount, Vk.CommandBuffer* pCommandBuffers)
		=> Parent.Functions.vkCmdExecuteCommands(Handle, commandBufferCount, pCommandBuffers);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DebugMarkerBeginEXT(Vk.EXT.DebugMarkerMarkerInfo* pMarkerInfo)
		=> Parent.Functions.vkCmdDebugMarkerBeginEXT(Handle, pMarkerInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DebugMarkerEndEXT()
		=> Parent.Functions.vkCmdDebugMarkerEndEXT(Handle);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DebugMarkerInsertEXT(Vk.EXT.DebugMarkerMarkerInfo* pMarkerInfo)
		=> Parent.Functions.vkCmdDebugMarkerInsertEXT(Handle, pMarkerInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void ExecuteGeneratedCommandsNV(Vk.Bool32 isPreprocessed, Vk.NV.GeneratedCommandsInfo* pGeneratedCommandsInfo)
		=> Parent.Functions.vkCmdExecuteGeneratedCommandsNV(Handle, isPreprocessed, pGeneratedCommandsInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void PreprocessGeneratedCommandsNV(Vk.NV.GeneratedCommandsInfo* pGeneratedCommandsInfo)
		=> Parent.Functions.vkCmdPreprocessGeneratedCommandsNV(Handle, pGeneratedCommandsInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BindPipelineShaderGroupNV(Vk.PipelineBindPoint pipelineBindPoint, Vk.Pipeline pipeline, uint groupIndex)
		=> Parent.Functions.vkCmdBindPipelineShaderGroupNV(Handle, pipelineBindPoint, pipeline, groupIndex);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void PushDescriptorSetKHR(Vk.PipelineBindPoint pipelineBindPoint, Vk.PipelineLayout layout, uint set, uint descriptorWriteCount, Vk.WriteDescriptorSet* pDescriptorWrites)
		=> Parent.Functions.vkCmdPushDescriptorSetKHR(Handle, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetDeviceMask(uint deviceMask)
		=> Parent.Functions.vkCmdSetDeviceMask(Handle, deviceMask);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetDeviceMaskKHR(uint deviceMask)
		=> Parent.Functions.vkCmdSetDeviceMaskKHR(Handle, deviceMask);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DispatchBase(uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
		=> Parent.Functions.vkCmdDispatchBase(Handle, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DispatchBaseKHR(uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
		=> Parent.Functions.vkCmdDispatchBaseKHR(Handle, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void PushDescriptorSetWithTemplateKHR(Vk.DescriptorUpdateTemplate descriptorUpdateTemplate, Vk.PipelineLayout layout, uint set, void* pData)
		=> Parent.Functions.vkCmdPushDescriptorSetWithTemplateKHR(Handle, descriptorUpdateTemplate, layout, set, pData);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetViewportWScalingNV(uint firstViewport, uint viewportCount, Vk.NV.ViewportWScaling* pViewportWScalings)
		=> Parent.Functions.vkCmdSetViewportWScalingNV(Handle, firstViewport, viewportCount, pViewportWScalings);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetDiscardRectangleEXT(uint firstDiscardRectangle, uint discardRectangleCount, Vk.Rect2D* pDiscardRectangles)
		=> Parent.Functions.vkCmdSetDiscardRectangleEXT(Handle, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetSampleLocationsEXT(Vk.EXT.SampleLocationsInfo* pSampleLocationsInfo)
		=> Parent.Functions.vkCmdSetSampleLocationsEXT(Handle, pSampleLocationsInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BeginDebugUtilsLabelEXT(Vk.EXT.DebugUtilsLabel* pLabelInfo)
		=> Parent.Functions.vkCmdBeginDebugUtilsLabelEXT(Handle, pLabelInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void EndDebugUtilsLabelEXT()
		=> Parent.Functions.vkCmdEndDebugUtilsLabelEXT(Handle);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void InsertDebugUtilsLabelEXT(Vk.EXT.DebugUtilsLabel* pLabelInfo)
		=> Parent.Functions.vkCmdInsertDebugUtilsLabelEXT(Handle, pLabelInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void WriteBufferMarkerAMD(Vk.PipelineStageFlags pipelineStage, Vk.Buffer dstBuffer, Vk.DeviceSize dstOffset, uint marker)
		=> Parent.Functions.vkCmdWriteBufferMarkerAMD(Handle, pipelineStage, dstBuffer, dstOffset, marker);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BeginRenderPass2(Vk.RenderPassBeginInfo* pRenderPassBegin, Vk.SubpassBeginInfo* pSubpassBeginInfo)
		=> Parent.Functions.vkCmdBeginRenderPass2(Handle, pRenderPassBegin, pSubpassBeginInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BeginRenderPass2KHR(Vk.RenderPassBeginInfo* pRenderPassBegin, Vk.SubpassBeginInfo* pSubpassBeginInfo)
		=> Parent.Functions.vkCmdBeginRenderPass2KHR(Handle, pRenderPassBegin, pSubpassBeginInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void NextSubpass2(Vk.SubpassBeginInfo* pSubpassBeginInfo, Vk.SubpassEndInfo* pSubpassEndInfo)
		=> Parent.Functions.vkCmdNextSubpass2(Handle, pSubpassBeginInfo, pSubpassEndInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void NextSubpass2KHR(Vk.SubpassBeginInfo* pSubpassBeginInfo, Vk.SubpassEndInfo* pSubpassEndInfo)
		=> Parent.Functions.vkCmdNextSubpass2KHR(Handle, pSubpassBeginInfo, pSubpassEndInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void EndRenderPass2(Vk.SubpassEndInfo* pSubpassEndInfo)
		=> Parent.Functions.vkCmdEndRenderPass2(Handle, pSubpassEndInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void EndRenderPass2KHR(Vk.SubpassEndInfo* pSubpassEndInfo)
		=> Parent.Functions.vkCmdEndRenderPass2KHR(Handle, pSubpassEndInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DrawIndirectCount(Vk.Buffer buffer, Vk.DeviceSize offset, Vk.Buffer countBuffer, Vk.DeviceSize countBufferOffset, uint maxDrawCount, uint stride)
		=> Parent.Functions.vkCmdDrawIndirectCount(Handle, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DrawIndirectCountKHR(Vk.Buffer buffer, Vk.DeviceSize offset, Vk.Buffer countBuffer, Vk.DeviceSize countBufferOffset, uint maxDrawCount, uint stride)
		=> Parent.Functions.vkCmdDrawIndirectCountKHR(Handle, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DrawIndirectCountAMD(Vk.Buffer buffer, Vk.DeviceSize offset, Vk.Buffer countBuffer, Vk.DeviceSize countBufferOffset, uint maxDrawCount, uint stride)
		=> Parent.Functions.vkCmdDrawIndirectCountAMD(Handle, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DrawIndexedIndirectCount(Vk.Buffer buffer, Vk.DeviceSize offset, Vk.Buffer countBuffer, Vk.DeviceSize countBufferOffset, uint maxDrawCount, uint stride)
		=> Parent.Functions.vkCmdDrawIndexedIndirectCount(Handle, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DrawIndexedIndirectCountKHR(Vk.Buffer buffer, Vk.DeviceSize offset, Vk.Buffer countBuffer, Vk.DeviceSize countBufferOffset, uint maxDrawCount, uint stride)
		=> Parent.Functions.vkCmdDrawIndexedIndirectCountKHR(Handle, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DrawIndexedIndirectCountAMD(Vk.Buffer buffer, Vk.DeviceSize offset, Vk.Buffer countBuffer, Vk.DeviceSize countBufferOffset, uint maxDrawCount, uint stride)
		=> Parent.Functions.vkCmdDrawIndexedIndirectCountAMD(Handle, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetCheckpointNV(void* pCheckpointMarker)
		=> Parent.Functions.vkCmdSetCheckpointNV(Handle, pCheckpointMarker);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BindTransformFeedbackBuffersEXT(uint firstBinding, uint bindingCount, Vk.Buffer* pBuffers, Vk.DeviceSize* pOffsets, Vk.DeviceSize* pSizes)
		=> Parent.Functions.vkCmdBindTransformFeedbackBuffersEXT(Handle, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BeginTransformFeedbackEXT(uint firstCounterBuffer, uint counterBufferCount, Vk.Buffer* pCounterBuffers, Vk.DeviceSize* pCounterBufferOffsets)
		=> Parent.Functions.vkCmdBeginTransformFeedbackEXT(Handle, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void EndTransformFeedbackEXT(uint firstCounterBuffer, uint counterBufferCount, Vk.Buffer* pCounterBuffers, Vk.DeviceSize* pCounterBufferOffsets)
		=> Parent.Functions.vkCmdEndTransformFeedbackEXT(Handle, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BeginQueryIndexedEXT(Vk.QueryPool queryPool, uint query, Vk.QueryControlFlags flags, uint index)
		=> Parent.Functions.vkCmdBeginQueryIndexedEXT(Handle, queryPool, query, flags, index);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void EndQueryIndexedEXT(Vk.QueryPool queryPool, uint query, uint index)
		=> Parent.Functions.vkCmdEndQueryIndexedEXT(Handle, queryPool, query, index);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DrawIndirectByteCountEXT(uint instanceCount, uint firstInstance, Vk.Buffer counterBuffer, Vk.DeviceSize counterBufferOffset, uint counterOffset, uint vertexStride)
		=> Parent.Functions.vkCmdDrawIndirectByteCountEXT(Handle, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetExclusiveScissorNV(uint firstExclusiveScissor, uint exclusiveScissorCount, Vk.Rect2D* pExclusiveScissors)
		=> Parent.Functions.vkCmdSetExclusiveScissorNV(Handle, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BindShadingRateImageNV(Vk.ImageView imageView, Vk.ImageLayout imageLayout)
		=> Parent.Functions.vkCmdBindShadingRateImageNV(Handle, imageView, imageLayout);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetViewportShadingRatePaletteNV(uint firstViewport, uint viewportCount, Vk.NV.ShadingRatePalette* pShadingRatePalettes)
		=> Parent.Functions.vkCmdSetViewportShadingRatePaletteNV(Handle, firstViewport, viewportCount, pShadingRatePalettes);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetCoarseSampleOrderNV(Vk.NV.CoarseSampleOrderType sampleOrderType, uint customSampleOrderCount, Vk.NV.CoarseSampleOrderCustom* pCustomSampleOrders)
		=> Parent.Functions.vkCmdSetCoarseSampleOrderNV(Handle, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DrawMeshTasksNV(uint taskCount, uint firstTask)
		=> Parent.Functions.vkCmdDrawMeshTasksNV(Handle, taskCount, firstTask);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DrawMeshTasksIndirectNV(Vk.Buffer buffer, Vk.DeviceSize offset, uint drawCount, uint stride)
		=> Parent.Functions.vkCmdDrawMeshTasksIndirectNV(Handle, buffer, offset, drawCount, stride);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DrawMeshTasksIndirectCountNV(Vk.Buffer buffer, Vk.DeviceSize offset, Vk.Buffer countBuffer, Vk.DeviceSize countBufferOffset, uint maxDrawCount, uint stride)
		=> Parent.Functions.vkCmdDrawMeshTasksIndirectCountNV(Handle, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void CopyAccelerationStructureNV(Vk.KHR.AccelerationStructure dst, Vk.KHR.AccelerationStructure src, Vk.KHR.CopyAccelerationStructureMode mode)
		=> Parent.Functions.vkCmdCopyAccelerationStructureNV(Handle, dst, src, mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void CopyAccelerationStructureKHR(Vk.KHR.CopyAccelerationStructureInfo* pInfo)
		=> Parent.Functions.vkCmdCopyAccelerationStructureKHR(Handle, pInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void CopyAccelerationStructureToMemoryKHR(Vk.KHR.CopyAccelerationStructureToMemoryInfo* pInfo)
		=> Parent.Functions.vkCmdCopyAccelerationStructureToMemoryKHR(Handle, pInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void CopyMemoryToAccelerationStructureKHR(Vk.KHR.CopyMemoryToAccelerationStructureInfo* pInfo)
		=> Parent.Functions.vkCmdCopyMemoryToAccelerationStructureKHR(Handle, pInfo);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void WriteAccelerationStructuresPropertiesKHR(uint accelerationStructureCount, Vk.KHR.AccelerationStructure* pAccelerationStructures, Vk.QueryType queryType, Vk.QueryPool queryPool, uint firstQuery)
		=> Parent.Functions.vkCmdWriteAccelerationStructuresPropertiesKHR(Handle, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void WriteAccelerationStructuresPropertiesNV(uint accelerationStructureCount, Vk.KHR.AccelerationStructure* pAccelerationStructures, Vk.QueryType queryType, Vk.QueryPool queryPool, uint firstQuery)
		=> Parent.Functions.vkCmdWriteAccelerationStructuresPropertiesNV(Handle, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BuildAccelerationStructureNV(Vk.NV.AccelerationStructureInfo* pInfo, Vk.Buffer instanceData, Vk.DeviceSize instanceOffset, Vk.Bool32 update, Vk.KHR.AccelerationStructure dst, Vk.KHR.AccelerationStructure src, Vk.Buffer scratch, Vk.DeviceSize scratchOffset)
		=> Parent.Functions.vkCmdBuildAccelerationStructureNV(Handle, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void TraceRaysKHR(Vk.KHR.StridedBufferRegion* pRaygenShaderBindingTable, Vk.KHR.StridedBufferRegion* pMissShaderBindingTable, Vk.KHR.StridedBufferRegion* pHitShaderBindingTable, Vk.KHR.StridedBufferRegion* pCallableShaderBindingTable, uint width, uint height, uint depth)
		=> Parent.Functions.vkCmdTraceRaysKHR(Handle, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void TraceRaysNV(Vk.Buffer raygenShaderBindingTableBuffer, Vk.DeviceSize raygenShaderBindingOffset, Vk.Buffer missShaderBindingTableBuffer, Vk.DeviceSize missShaderBindingOffset, Vk.DeviceSize missShaderBindingStride, Vk.Buffer hitShaderBindingTableBuffer, Vk.DeviceSize hitShaderBindingOffset, Vk.DeviceSize hitShaderBindingStride, Vk.Buffer callableShaderBindingTableBuffer, Vk.DeviceSize callableShaderBindingOffset, Vk.DeviceSize callableShaderBindingStride, uint width, uint height, uint depth)
		=> Parent.Functions.vkCmdTraceRaysNV(Handle, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void TraceRaysIndirectKHR(Vk.KHR.StridedBufferRegion* pRaygenShaderBindingTable, Vk.KHR.StridedBufferRegion* pMissShaderBindingTable, Vk.KHR.StridedBufferRegion* pHitShaderBindingTable, Vk.KHR.StridedBufferRegion* pCallableShaderBindingTable, Vk.Buffer buffer, Vk.DeviceSize offset)
		=> Parent.Functions.vkCmdTraceRaysIndirectKHR(Handle, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, buffer, offset);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public VulkanResult SetPerformanceMarkerINTEL(Vk.INTEL.PerformanceMarkerInfo* pMarkerInfo)
		=> new(Parent.Functions.vkCmdSetPerformanceMarkerINTEL(Handle, pMarkerInfo), "vkCmdSetPerformanceMarkerINTEL");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public VulkanResult SetPerformanceStreamMarkerINTEL(Vk.INTEL.PerformanceStreamMarkerInfo* pMarkerInfo)
		=> new(Parent.Functions.vkCmdSetPerformanceStreamMarkerINTEL(Handle, pMarkerInfo), "vkCmdSetPerformanceStreamMarkerINTEL");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public VulkanResult SetPerformanceOverrideINTEL(Vk.INTEL.PerformanceOverrideInfo* pOverrideInfo)
		=> new(Parent.Functions.vkCmdSetPerformanceOverrideINTEL(Handle, pOverrideInfo), "vkCmdSetPerformanceOverrideINTEL");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetLineStippleEXT(uint lineStippleFactor, ushort lineStipplePattern)
		=> Parent.Functions.vkCmdSetLineStippleEXT(Handle, lineStippleFactor, lineStipplePattern);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BuildAccelerationStructureKHR(uint infoCount, Vk.KHR.AccelerationStructureBuildGeometryInfo* pInfos, Vk.KHR.AccelerationStructureBuildOffsetInfo** ppOffsetInfos)
		=> Parent.Functions.vkCmdBuildAccelerationStructureKHR(Handle, infoCount, pInfos, ppOffsetInfos);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BuildAccelerationStructureIndirectKHR(Vk.KHR.AccelerationStructureBuildGeometryInfo* pInfo, Vk.Buffer indirectBuffer, Vk.DeviceSize indirectOffset, uint indirectStride)
		=> Parent.Functions.vkCmdBuildAccelerationStructureIndirectKHR(Handle, pInfo, indirectBuffer, indirectOffset, indirectStride);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetCullModeEXT(Vk.CullModeFlags cullMode)
		=> Parent.Functions.vkCmdSetCullModeEXT(Handle, cullMode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetFrontFaceEXT(Vk.FrontFace frontFace)
		=> Parent.Functions.vkCmdSetFrontFaceEXT(Handle, frontFace);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetPrimitiveTopologyEXT(Vk.PrimitiveTopology primitiveTopology)
		=> Parent.Functions.vkCmdSetPrimitiveTopologyEXT(Handle, primitiveTopology);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetViewportWithCountEXT(uint viewportCount, Vk.Viewport* pViewports)
		=> Parent.Functions.vkCmdSetViewportWithCountEXT(Handle, viewportCount, pViewports);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetScissorWithCountEXT(uint scissorCount, Vk.Rect2D* pScissors)
		=> Parent.Functions.vkCmdSetScissorWithCountEXT(Handle, scissorCount, pScissors);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void BindVertexBuffers2EXT(uint firstBinding, uint bindingCount, Vk.Buffer* pBuffers, Vk.DeviceSize* pOffsets, Vk.DeviceSize* pSizes, Vk.DeviceSize* pStrides)
		=> Parent.Functions.vkCmdBindVertexBuffers2EXT(Handle, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetDepthTestEnableEXT(Vk.Bool32 depthTestEnable)
		=> Parent.Functions.vkCmdSetDepthTestEnableEXT(Handle, depthTestEnable);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetDepthWriteEnableEXT(Vk.Bool32 depthWriteEnable)
		=> Parent.Functions.vkCmdSetDepthWriteEnableEXT(Handle, depthWriteEnable);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetDepthCompareOpEXT(Vk.CompareOp depthCompareOp)
		=> Parent.Functions.vkCmdSetDepthCompareOpEXT(Handle, depthCompareOp);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetDepthBoundsTestEnableEXT(Vk.Bool32 depthBoundsTestEnable)
		=> Parent.Functions.vkCmdSetDepthBoundsTestEnableEXT(Handle, depthBoundsTestEnable);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetStencilTestEnableEXT(Vk.Bool32 stencilTestEnable)
		=> Parent.Functions.vkCmdSetStencilTestEnableEXT(Handle, stencilTestEnable);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetStencilOpEXT(Vk.StencilFaceFlags faceMask, Vk.StencilOp failOp, Vk.StencilOp passOp, Vk.StencilOp depthFailOp, Vk.CompareOp compareOp)
		=> Parent.Functions.vkCmdSetStencilOpEXT(Handle, faceMask, failOp, passOp, depthFailOp, compareOp);

}

} // namespace VVK
