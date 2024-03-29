// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

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
            IReadOnlyList<Robot> content = default;
            Optional<PagedObjectType> objectType = default;
            PageMetadata metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    List<Robot> array = new List<Robot>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Robot.DeserializeRobot(item));
                    }
                    content = array;
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objectType = property.Value.GetString().ToPagedObjectType();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    metadata = PageMetadata.DeserializePageMetadata(property.Value);
                    continue;
                }
            }
            return new RobotPage(Optional.ToNullable(objectType), metadata, content);
        }
    }
}
