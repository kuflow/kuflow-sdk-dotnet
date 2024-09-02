// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;

namespace KuFlow.Rest.Models
{
    public partial class ProcessItem
    {
        internal static ProcessItem DeserializeProcessItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid id = default;
            ProcessItemType type = default;
            Guid processId = default;
            Guid? ownerId = default;
            Guid? tenantId = default;
            ProcessItemTask task = default;
            ProcessItemMessage message = default;
            Guid? createdBy = default;
            DateTimeOffset? createdAt = default;
            Guid? lastModifiedBy = default;
            DateTimeOffset? lastModifiedAt = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToProcessItemType();
                    continue;
                }
                if (property.NameEquals("processId"u8))
                {
                    processId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("ownerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ownerId = property.Value.GetGuid();
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
                if (property.NameEquals("task"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    task = ProcessItemTask.DeserializeProcessItemTask(property.Value);
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    message = ProcessItemMessage.DeserializeProcessItemMessage(property.Value);
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
            return new ProcessItem(
                createdBy,
                createdAt,
                lastModifiedBy,
                lastModifiedAt,
                id,
                type,
                processId,
                ownerId,
                tenantId,
                task,
                message);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ProcessItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeProcessItem(document.RootElement);
        }
    }
}
