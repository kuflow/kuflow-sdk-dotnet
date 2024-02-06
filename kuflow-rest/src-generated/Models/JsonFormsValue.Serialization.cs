// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    public partial class JsonFormsValue : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Valid))
            {
                writer.WritePropertyName("valid"u8);
                writer.WriteBooleanValue(Valid.Value);
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartObject();
                foreach (var item in Data)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static JsonFormsValue DeserializeJsonFormsValue(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> valid = default;
            Optional<IDictionary<string, object>> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("valid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valid = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    data = dictionary;
                    continue;
                }
            }
            return new JsonFormsValue(Optional.ToNullable(valid), Optional.ToDictionary(data));
        }
    }
}