// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    public partial class Log : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id.Value);
            }
            if (Optional.IsDefined(CreatedAt))
            {
                writer.WritePropertyName("createdAt");
                writer.WriteStringValue(CreatedAt.Value, "O");
            }
            writer.WritePropertyName("message");
            writer.WriteStringValue(Message);
            writer.WritePropertyName("level");
            writer.WriteStringValue(Level.ToSerialString());
            writer.WriteEndObject();
        }

        internal static Log DeserializeLog(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> id = default;
            Optional<DateTimeOffset> createdAt = default;
            string message = default;
            LogLevel level = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("createdAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"))
                {
                    level = property.Value.GetString().ToLogLevel();
                    continue;
                }
            }
            return new Log(Optional.ToNullable(id), Optional.ToNullable(createdAt), message, level);
        }
    }
}
