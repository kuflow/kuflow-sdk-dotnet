// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    public partial class ProcessSaveElementCommand : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("elementDefinitionCode"u8);
            writer.WriteStringValue(ElementDefinitionCode);
            if (Optional.IsCollectionDefined(ElementValues))
            {
                writer.WritePropertyName("elementValues"u8);
                writer.WriteStartArray();
                foreach (var item in ElementValues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}