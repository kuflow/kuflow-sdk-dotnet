// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    internal static partial class TaskElementValueTypeExtensions
    {
        public static string ToSerialString(this TaskElementValueType value) => value switch
        {
            TaskElementValueType.String => "STRING",
            TaskElementValueType.Number => "NUMBER",
            TaskElementValueType.Object => "OBJECT",
            TaskElementValueType.Document => "DOCUMENT",
            TaskElementValueType.Principal => "PRINCIPAL",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TaskElementValueType value.")
        };

        public static TaskElementValueType ToTaskElementValueType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "STRING")) return TaskElementValueType.String;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NUMBER")) return TaskElementValueType.Number;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "OBJECT")) return TaskElementValueType.Object;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "DOCUMENT")) return TaskElementValueType.Document;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PRINCIPAL")) return TaskElementValueType.Principal;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TaskElementValueType value.");
        }
    }
}