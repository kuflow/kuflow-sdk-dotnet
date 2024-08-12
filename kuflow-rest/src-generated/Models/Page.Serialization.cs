// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace KuFlow.Rest.Models
{
    public partial class Page
    {
        internal static Page DeserializePage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PageMetadata metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadata"u8))
                {
                    metadata = PageMetadata.DeserializePageMetadata(property.Value);
                    continue;
                }
            }
            return new Page(metadata);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Page FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePage(document.RootElement);
        }
    }
}
