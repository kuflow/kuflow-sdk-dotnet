// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    internal static partial class ProcessItemTaskStateExtensions
    {
        public static string ToSerialString(this ProcessItemTaskState value) => value switch
        {
            ProcessItemTaskState.Ready => "READY",
            ProcessItemTaskState.Claimed => "CLAIMED",
            ProcessItemTaskState.Completed => "COMPLETED",
            ProcessItemTaskState.Cancelled => "CANCELLED",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProcessItemTaskState value.")
        };

        public static ProcessItemTaskState ToProcessItemTaskState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "READY")) return ProcessItemTaskState.Ready;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "CLAIMED")) return ProcessItemTaskState.Claimed;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "COMPLETED")) return ProcessItemTaskState.Completed;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "CANCELLED")) return ProcessItemTaskState.Cancelled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProcessItemTaskState value.");
        }
    }
}
