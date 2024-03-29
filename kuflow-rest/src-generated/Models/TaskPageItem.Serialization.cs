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
    public partial class TaskPageItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id.Value);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            writer.WritePropertyName("taskDefinition"u8);
            writer.WriteObjectValue(TaskDefinition);
            writer.WritePropertyName("processId"u8);
            writer.WriteStringValue(ProcessId);
            if (Optional.IsCollectionDefined(ElementValues))
            {
                writer.WritePropertyName("elementValues"u8);
                writer.WriteStartObject();
                foreach (var item in ElementValues)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(JsonFormsValue))
            {
                writer.WritePropertyName("jsonFormsValue"u8);
                writer.WriteObjectValue(JsonFormsValue);
            }
            if (Optional.IsDefined(Owner))
            {
                writer.WritePropertyName("owner"u8);
                writer.WriteObjectValue(Owner);
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

        internal static TaskPageItem DeserializeTaskPageItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> id = default;
            Optional<TaskState> state = default;
            TaskDefinitionSummary taskDefinition = default;
            Guid processId = default;
            Optional<IDictionary<string, IList<TaskElementValue>>> elementValues = default;
            Optional<JsonFormsValue> jsonFormsValue = default;
            Optional<Principal> owner = default;
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString().ToTaskState();
                    continue;
                }
                if (property.NameEquals("taskDefinition"u8))
                {
                    taskDefinition = TaskDefinitionSummary.DeserializeTaskDefinitionSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("processId"u8))
                {
                    processId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("elementValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IList<TaskElementValue>> dictionary = new Dictionary<string, IList<TaskElementValue>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<TaskElementValue> array = new List<TaskElementValue>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TaskElementValue.DeserializeTaskElementValue(item));
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    elementValues = dictionary;
                    continue;
                }
                if (property.NameEquals("jsonFormsValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jsonFormsValue = JsonFormsValue.DeserializeJsonFormsValue(property.Value);
                    continue;
                }
                if (property.NameEquals("owner"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    owner = Principal.DeserializePrincipal(property.Value);
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
            return new TaskPageItem(Optional.ToNullable(objectType), Optional.ToNullable(createdBy), Optional.ToNullable(createdAt), Optional.ToNullable(lastModifiedBy), Optional.ToNullable(lastModifiedAt), Optional.ToNullable(id), Optional.ToNullable(state), taskDefinition, processId, Optional.ToDictionary(elementValues), jsonFormsValue.Value, owner.Value, Optional.ToNullable(tenantId));
        }
    }
}
