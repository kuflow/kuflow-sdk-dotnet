// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;

namespace KuFlow.Rest.Models
{
    public partial class TenantPageItem
    {
        internal static TenantPageItem DeserializeTenantPageItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid id = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new TenantPageItem(id, name);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TenantPageItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTenantPageItem(document.RootElement);
        }
    }
}
