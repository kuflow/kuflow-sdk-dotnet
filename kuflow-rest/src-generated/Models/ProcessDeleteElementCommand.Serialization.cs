// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    public partial class ProcessDeleteElementCommand : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("elementDefinitionCode"u8);
            writer.WriteStringValue(ElementDefinitionCode);
            writer.WriteEndObject();
        }
    }
}