// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    internal partial class UnknownTaskElementValue : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Valid))
            {
                writer.WritePropertyName("valid");
                writer.WriteBooleanValue(Valid.Value);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToSerialString());
            writer.WriteEndObject();
        }

        internal static UnknownTaskElementValue DeserializeUnknownTaskElementValue(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> valid = default;
            TaskElementValueType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("valid"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valid = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString().ToTaskElementValueType();
                    continue;
                }
            }
            return new UnknownTaskElementValue(Optional.ToNullable(valid), type);
        }
    }
}
