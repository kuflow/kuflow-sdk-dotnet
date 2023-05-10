// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Kuflow.Rest.Models
{
    public partial class TaskPage
    {
        internal static TaskPage DeserializeTaskPage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<TaskPageItem> content = default;
            PagedObjectType objectType = default;
            PageMetadata metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"))
                {
                    List<TaskPageItem> array = new List<TaskPageItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TaskPageItem.DeserializeTaskPageItem(item));
                    }
                    content = array;
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString().ToPagedObjectType();
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    metadata = PageMetadata.DeserializePageMetadata(property.Value);
                    continue;
                }
            }
            return new TaskPage(objectType, metadata, content);
        }
    }
}
