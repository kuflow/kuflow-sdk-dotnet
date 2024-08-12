// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;

namespace KuFlow.Rest.Models
{
    public partial class TenantUser
    {
        internal static TenantUser DeserializeTenantUser(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid id = default;
            JsonValue metadata = default;
            Principal principal = default;
            Guid tenantId = default;
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
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = JsonValue.DeserializeJsonValue(property.Value);
                    continue;
                }
                if (property.NameEquals("principal"u8))
                {
                    principal = Principal.DeserializePrincipal(property.Value);
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetGuid();
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
            return new TenantUser(
                createdBy,
                createdAt,
                lastModifiedBy,
                lastModifiedAt,
                id,
                metadata,
                principal,
                tenantId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new TenantUser FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTenantUser(document.RootElement);
        }
    }
}
