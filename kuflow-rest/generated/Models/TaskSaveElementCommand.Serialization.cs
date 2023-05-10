// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Kuflow.Rest.Models
{
    public partial class TaskSaveElementCommand : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("elementDefinitionCode");
            writer.WriteStringValue(ElementDefinitionCode);
            if (Optional.IsCollectionDefined(ElementValues))
            {
                writer.WritePropertyName("elementValues");
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
