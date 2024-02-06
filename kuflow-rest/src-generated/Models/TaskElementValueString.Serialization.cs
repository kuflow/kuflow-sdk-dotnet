// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    public partial class TaskElementValueString : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(Valid))
            {
                writer.WritePropertyName("valid"u8);
                writer.WriteBooleanValue(Valid.Value);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToSerialString());
            writer.WriteEndObject();
        }

        internal static TaskElementValueString DeserializeTaskElementValueString(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> value = default;
            Optional<bool> valid = default;
            TaskElementValueType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valid = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToTaskElementValueType();
                    continue;
                }
            }
            return new TaskElementValueString(Optional.ToNullable(valid), type, value.Value);
        }
    }
}