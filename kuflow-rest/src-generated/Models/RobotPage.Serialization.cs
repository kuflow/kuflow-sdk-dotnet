// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace KuFlow.Rest.Models
{
    public partial class RobotPage
    {
        internal static RobotPage DeserializeRobotPage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<RobotPageItem> content = default;
            PageMetadata metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    List<RobotPageItem> array = new List<RobotPageItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RobotPageItem.DeserializeRobotPageItem(item));
                    }
                    content = array;
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    metadata = PageMetadata.DeserializePageMetadata(property.Value);
                    continue;
                }
            }
            return new RobotPage(metadata, content);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new RobotPage FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRobotPage(document.RootElement);
        }
    }
}
