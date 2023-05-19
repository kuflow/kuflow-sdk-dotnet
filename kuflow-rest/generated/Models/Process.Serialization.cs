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
    public partial class Process : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id.Value);
            }
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject");
                writer.WriteStringValue(Subject);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            writer.WritePropertyName("processDefinition");
            writer.WriteObjectValue(ProcessDefinition);
            if (Optional.IsCollectionDefined(ElementValues))
            {
                writer.WritePropertyName("elementValues");
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
            if (Optional.IsDefined(Initiator))
            {
                writer.WritePropertyName("initiator");
                writer.WriteObjectValue(Initiator);
            }
            if (Optional.IsDefined(RelatedProcess))
            {
                writer.WritePropertyName("relatedProcess");
                writer.WriteObjectValue(RelatedProcess);
            }
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType.ToSerialString());
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy");
                writer.WriteStringValue(CreatedBy.Value);
            }
            if (Optional.IsDefined(CreatedAt))
            {
                writer.WritePropertyName("createdAt");
                writer.WriteStringValue(CreatedAt.Value, "O");
            }
            if (Optional.IsDefined(LastModifiedBy))
            {
                writer.WritePropertyName("lastModifiedBy");
                writer.WriteStringValue(LastModifiedBy.Value);
            }
            if (Optional.IsDefined(LastModifiedAt))
            {
                writer.WritePropertyName("lastModifiedAt");
                writer.WriteStringValue(LastModifiedAt.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static Process DeserializeProcess(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> id = default;
            Optional<string> subject = default;
            Optional<ProcessState> state = default;
            ProcessDefinitionSummary processDefinition = default;
            Optional<IDictionary<string, IList<ProcessElementValue>>> elementValues = default;
            Optional<Principal> initiator = default;
            Optional<RelatedProcess> relatedProcess = default;
            AuditedObjectType objectType = default;
            Optional<Guid> createdBy = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<Guid> lastModifiedBy = default;
            Optional<DateTimeOffset> lastModifiedAt = default;
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
                if (property.NameEquals("subject"))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString().ToProcessState();
                    continue;
                }
                if (property.NameEquals("processDefinition"))
                {
                    processDefinition = ProcessDefinitionSummary.DeserializeProcessDefinitionSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("elementValues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IList<ProcessElementValue>> dictionary = new Dictionary<string, IList<ProcessElementValue>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<ProcessElementValue> array = new List<ProcessElementValue>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ProcessElementValue.DeserializeProcessElementValue(item));
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    elementValues = dictionary;
                    continue;
                }
                if (property.NameEquals("initiator"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initiator = Principal.DeserializePrincipal(property.Value);
                    continue;
                }
                if (property.NameEquals("relatedProcess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    relatedProcess = RelatedProcess.DeserializeRelatedProcess(property.Value);
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString().ToAuditedObjectType();
                    continue;
                }
                if (property.NameEquals("createdBy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdBy = property.Value.GetGuid();
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
                if (property.NameEquals("lastModifiedBy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedBy = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("lastModifiedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new Process(objectType, Optional.ToNullable(createdBy), Optional.ToNullable(createdAt), Optional.ToNullable(lastModifiedBy), Optional.ToNullable(lastModifiedAt), Optional.ToNullable(id), subject.Value, Optional.ToNullable(state), processDefinition, Optional.ToDictionary(elementValues), initiator.Value, relatedProcess.Value);
        }
    }
}
