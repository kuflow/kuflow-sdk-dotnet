// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    internal static partial class ProcessElementValueTypeExtensions
    {
        public static string ToSerialString(this ProcessElementValueType value) => value switch
        {
            ProcessElementValueType.String => "STRING",
            ProcessElementValueType.Number => "NUMBER",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProcessElementValueType value.")
        };

        public static ProcessElementValueType ToProcessElementValueType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "STRING")) return ProcessElementValueType.String;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NUMBER")) return ProcessElementValueType.Number;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProcessElementValueType value.");
        }
    }
}
