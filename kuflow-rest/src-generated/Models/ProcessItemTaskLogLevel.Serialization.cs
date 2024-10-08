// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    internal static partial class ProcessItemTaskLogLevelExtensions
    {
        public static string ToSerialString(this ProcessItemTaskLogLevel value) => value switch
        {
            ProcessItemTaskLogLevel.Info => "INFO",
            ProcessItemTaskLogLevel.Warn => "WARN",
            ProcessItemTaskLogLevel.Error => "ERROR",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProcessItemTaskLogLevel value.")
        };

        public static ProcessItemTaskLogLevel ToProcessItemTaskLogLevel(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "INFO")) return ProcessItemTaskLogLevel.Info;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "WARN")) return ProcessItemTaskLogLevel.Warn;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ERROR")) return ProcessItemTaskLogLevel.Error;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProcessItemTaskLogLevel value.");
        }
    }
}
