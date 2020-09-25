﻿/*
 * MIT License - Copyright (c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the MIT License, the text of which can be found in the 'LICENSE'
 * file at the root of this repository, or online at <https://opensource.org/licenses/MIT>.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;

namespace Gen
{
	// Writes the processed spec results out to C# source files
	public static class APIGenerator
	{
		// Top-level writing task
		public static bool GenerateResults(ProcessResults res)
		{
			// Generate vendor directories
			try {
				foreach (var vendor in res.Vendors) {
					var dirpath = Path.Combine(ArgParse.OutputPath, vendor.Key);
					if (!Directory.Exists(dirpath)) {
						Directory.CreateDirectory(dirpath);
					}
				}
			}
			catch (Exception ex) {
				Program.PrintError($"Failed to generate vendor folders - {ex.Message}");
				return false;
			}

			// Write the API constants
			if (!GenerateConstants(res)) {
				return false;
			}

			// Write the vendor contents
			foreach (var vendor in res.Vendors) {
				Console.WriteLine($"Generating files for {vendor.Value.DisplayName} ...");
				if (!GenerateEnums(vendor.Value)) {
					return false;
				}
				if (!GenerateStructs(vendor.Value, res.Constants)) {
					return false;
				}
			}

			return true;
		}

		// API constant generation
		private static bool GenerateConstants(ProcessResults res)
		{
			Console.WriteLine("Generating API constants...");

			try {
				// Constants file context and class context
				using var file = new SourceFile("Vk.Constants.cs", "VVK.Vk");
				using var constClass = file.PushBlock("public static class Constants");

				// Write each constant
				foreach (var constSpec in res.Constants.Values) {
					constClass.WriteLine($"public const {constSpec.TypeName} {constSpec.Name} = {constSpec.Value};");
				}
			}
			catch (Exception ex) {
				Program.PrintError($"Failed to generate API constants - {ex.Message}");
				return false;
			}

			return true;
		}

		// Enum generation
		private static bool GenerateEnums(Vendor vendor)
		{
			if (vendor.Enums.Count == 0) {
				return true;
			}

			Program.PrintVerbose($"\tGenerating enums for {vendor.DisplayName}");

			try {
				// The file context
				using var file = new SourceFile(vendor.GetSourceFilename("Enums"), vendor.NamespaceName);

				// Visit each enum
				foreach (var enumSpec in vendor.Enums.Values) {
					if (enumSpec.IsBitmask) {
						file.WriteLine("[Flags]");
					}
					using var enumBlock = 
						file.PushBlock($"public enum {enumSpec.Name} : {(enumSpec.IsBitmask ? "uint" : "int")}");

					// Visit each value
					foreach (var value in enumSpec.Values) {
						enumBlock.WriteLine($"{value.Name} = {value.Value},");
					}
				}
			}
			catch (Exception ex) {
				Program.PrintError($"Failed to generate enums for {vendor.DisplayName} - {ex.Message}");
				return false;
			}

			return true;
		}

		// Struct generation
		private static bool GenerateStructs(Vendor vendor, Dictionary<string, ConstantOut> consts)
		{
			if (vendor.Structs.Count == 0) {
				return true;
			}

			Program.PrintVerbose($"\tGenerating structs for {vendor.DisplayName}");

			try {
				// File context
				using var file = new SourceFile(vendor.GetSourceFilename("Structs"), vendor.NamespaceName);

				// Visit each struct
				foreach (var structSpec in vendor.Structs.Values) {
					// Write the struct header
					file.WriteLine("[StructLayout(LayoutKind.Sequential)]");
					using var enumBlock = file.PushBlock($"public unsafe partial struct {structSpec.Name}");

					// Visit the fields
					foreach (var field in structSpec.Fields) {
						if (field.SizeLiteral is not null) {
							if (field.IsFixed) {
								enumBlock.WriteLine($"public fixed {field.Type} {field.Name}[{field.SizeLiteral}];");
							}
							else {
								var literal = Char.IsDigit(field.SizeLiteral[0]) 
									? field.SizeLiteral 
									: consts[field.SizeLiteral.Substring(field.SizeLiteral.LastIndexOf('.') + 1)].Value;
								var count = Int32.Parse(literal);
								for (int i = 0; i < count; ++i) {
									enumBlock.WriteLine($"public {field.Type} {field.Name}_{i};");
								}
							}
						}
						else {
							enumBlock.WriteLine($"public {field.Type} {field.Name};");
						}
					}
				}
			}
			catch (Exception ex) {
				Program.PrintError($"Failed to generate structs for {vendor.DisplayName} - {ex.Message}");
				return false;
			}

			return true;
		}
	}
}