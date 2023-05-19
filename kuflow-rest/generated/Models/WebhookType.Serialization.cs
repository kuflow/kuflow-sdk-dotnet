// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    internal static partial class WebhookTypeExtensions
    {
        public static string ToSerialString(this WebhookType value) => value switch
        {
            WebhookType.ProcessStateChanged => "PROCESS.STATE_CHANGED",
            WebhookType.TaskStateChanged => "TASK.STATE_CHANGED",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WebhookType value.")
        };

        public static WebhookType ToWebhookType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PROCESS.STATE_CHANGED")) return WebhookType.ProcessStateChanged;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "TASK.STATE_CHANGED")) return WebhookType.TaskStateChanged;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WebhookType value.");
        }
    }
}
