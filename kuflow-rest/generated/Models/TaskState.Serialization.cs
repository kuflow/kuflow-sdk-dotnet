// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    internal static partial class TaskStateExtensions
    {
        public static string ToSerialString(this TaskState value) => value switch
        {
            TaskState.Ready => "READY",
            TaskState.Claimed => "CLAIMED",
            TaskState.Completed => "COMPLETED",
            TaskState.Cancelled => "CANCELLED",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TaskState value.")
        };

        public static TaskState ToTaskState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "READY")) return TaskState.Ready;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "CLAIMED")) return TaskState.Claimed;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "COMPLETED")) return TaskState.Completed;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "CANCELLED")) return TaskState.Cancelled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TaskState value.");
        }
    }
}
