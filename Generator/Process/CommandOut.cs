﻿/*
 * MIT License - Copyright (c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at <https://opensource.org/licenses/MIT>.
 */

using System;
using System.Collections.Generic;

namespace Gen
{
	// The scope of a command within the Global/Instance/Device distinction space
	public enum CommandScope
	{
		Global,   // Function is loaded at the global level
		Instance, // Function is loaded on an instant object
		Device    // Function is loaded on a device object
	}

	// The scope of a command with object space (which object is the command's first argument)
	public enum ObjectScope
	{
		Global,         // Function is called globally (same as CommandScope.Global)
		Instance,       // Function is called on an instance
		PhysicalDevice, // Function is called on a physical device
		Device,         // Function is called on a logical device
		Queue,          // Function is called on a device queue
		CommandBuffer   // Function is called on a command buffer
	}

	// Processed command from the spec
	public sealed class CommandOut
	{
		// The known global scope functions
		private static readonly List<string> GLOBAL_FUNCTIONS = new() {
			"vkCreateInstance", "vkEnumerateInstanceExtensionProperties",
			"vkEnumerateInstanceLayerProperties", "vkEnumerateInstanceVersion",
			"vkGetInstanceProcAddr",
			"vkGetDeviceProcAddr" // Not *technically* a global function, but can and is used as such
		};
		// Known C# keywords that are used as argument names
		private static readonly List<string> KEYWORD_ARGS = new() { 
			"object", "event"
		};

		// Represents a processed argument
		public record Argument(string Name, string Type);

		#region Fields
		// The spec that this command was generated from
		public readonly CommandSpec Spec;
		// The name of the function
		public readonly string Name;
		// The C# function pointer prototype
		public readonly string PtrPrototype;
		// The load scope for the function
		public readonly CommandScope CommandScope;
		// The object scope for the function
		public readonly ObjectScope ObjectScope;
		// If the function is a core function
		public readonly bool IsCore;
		// The arguments of the function
		public readonly List<Argument> Arguments;
		// The processed return type name
		public readonly string ReturnType;

		// Forward
		public bool IsAlias => Spec.IsAlias;
		public CommandSpec? Alias => Spec.Alias;
		#endregion // Fields

		private CommandOut(CommandSpec spec, string name, string proto, CommandScope cmdScope, ObjectScope objScope, 
			bool core, List<Argument> args, string retType)
		{
			Spec = spec;
			Name = name;
			PtrPrototype = proto;
			CommandScope = cmdScope;
			ObjectScope = objScope;
			IsCore = core;
			Arguments = args;
			ReturnType = retType;
		}

		// Process
		public static CommandOut? TryProcess(CommandSpec spec, NameHelper names)
		{
			// Get the arg types
			var argProto = new string[spec.Arguments.Count + 1];
			List<Argument> args = new();
			int aidx = 0;
			foreach (var arg in spec.Arguments) {
				if (!names.ProcessGeneralTypeName(arg.Type, out argProto[aidx])) {
					Program.PrintError($"Failed to parse argument type {arg.Type}");
					return null;
				}
				var aname = KEYWORD_ARGS.Contains(arg.Name) ? ('@' + arg.Name) : arg.Name;
				args.Add(new(aname, argProto[aidx++]));
			}

			// Get the return type
			if (!names.ProcessGeneralTypeName(spec.ReturnType, out var retType)) {
				Program.PrintError($"Failed to parse func return type '{spec.ReturnType}'");
				return null;
			}
			argProto[^1] = retType;

			// Figure the scope of the function
			CommandScope scope;
			if (GLOBAL_FUNCTIONS.Contains(spec.Name)) {
				scope = CommandScope.Global;
			}
			else if (spec.Arguments.Count > 0 &&
					(spec.Arguments[0].Type == "VkInstance" || spec.Arguments[0].Type == "VkPhysicalDevice")) {
				scope = CommandScope.Instance;
			}
			else {
				scope = CommandScope.Device;
			}

			// Special case for global "*ProcAddr" functions
			if (scope == CommandScope.Global && argProto[^1] == "delegate* managed<void>") {
				argProto[^1] = "delegate* unmanaged<void>";
			}

			// Get the object scope
			var objScope = (scope == CommandScope.Global) ? ObjectScope.Global : argProto[0] switch { 
				"Vk.Instance" => ObjectScope.Instance,
				"Vk.PhysicalDevice" => ObjectScope.PhysicalDevice,
				"Vk.Device" => ObjectScope.Device,
				"Vk.Queue" => ObjectScope.Queue,
				"Vk.CommandBuffer" => ObjectScope.CommandBuffer,
				_ => throw new NotImplementedException("Failed to get the command object scope")
			};

			// Return
			return new(spec, spec.Name, $"delegate* unmanaged<{String.Join(", ", argProto)}>", scope, objScope,
				!names.IsVendorType(spec.Name), args, argProto[^1]);
		}
	}
}
