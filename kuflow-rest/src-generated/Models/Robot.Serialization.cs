// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    public partial class Robot : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("code"u8);
            writer.WriteStringValue(Code);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("sourceType"u8);
            writer.WriteStringValue(SourceType.ToSerialString());
            if (Optional.IsDefined(SourceFile))
            {
                writer.WritePropertyName("sourceFile"u8);
                writer.WriteObjectValue(SourceFile);
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables"u8);
                writer.WriteStartObject();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("objectType"u8);
                writer.WriteStringValue(ObjectType.Value.ToSerialString());
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteStringValue(CreatedBy.Value);
            }
            if (Optional.IsDefined(CreatedAt))
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedAt.Value, "O");
            }
            if (Optional.IsDefined(LastModifiedBy))
            {
                writer.WritePropertyName("lastModifiedBy"u8);
                writer.WriteStringValue(LastModifiedBy.Value);
            }
            if (Optional.IsDefined(LastModifiedAt))
            {
                writer.WritePropertyName("lastModifiedAt"u8);
                writer.WriteStringValue(LastModifiedAt.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static Robot DeserializeRobot(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid id = default;
            string code = default;
            string name = default;
            Optional<string> description = default;
            RobotSourceType sourceType = default;
            Optional<RobotSourceFile> sourceFile = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            Optional<Guid> tenantId = default;
            Optional<AuditedObjectType> objectType = default;
            Optional<Guid> createdBy = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<Guid> lastModifiedBy = default;
            Optional<DateTimeOffset> lastModifiedAt = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceType"u8))
                {
                    sourceType = property.Value.GetString().ToRobotSourceType();
                    continue;
                }
                if (property.NameEquals("sourceFile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceFile = RobotSourceFile.DeserializeRobotSourceFile(property.Value);
                    continue;
                }
                if (property.NameEquals("environmentVariables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objectType = property.Value.GetString().ToAuditedObjectType();
                    continue;
                }
                if (property.NameEquals("createdBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdBy = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedBy = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("lastModifiedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new Robot(Optional.ToNullable(objectType), Optional.ToNullable(createdBy), Optional.ToNullable(createdAt), Optional.ToNullable(lastModifiedBy), Optional.ToNullable(lastModifiedAt), id, code, name, description.Value, sourceType, sourceFile.Value, Optional.ToDictionary(environmentVariables), Optional.ToNullable(tenantId));
        }
    }
}
