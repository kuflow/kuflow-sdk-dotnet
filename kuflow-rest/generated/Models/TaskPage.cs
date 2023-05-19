// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    /// <summary> The TaskPage. </summary>
    public partial class TaskPage : Page
    {
        /// <summary> Initializes a new instance of TaskPage. </summary>
        /// <param name="metadata"></param>
        /// <param name="content"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadata"/> or <paramref name="content"/> is null. </exception>
        internal TaskPage(PageMetadata metadata, IEnumerable<TaskPageItem> content) : base(metadata)
        {
            Argument.AssertNotNull(metadata, nameof(metadata));
            Argument.AssertNotNull(content, nameof(content));

            Content = content.ToList();
            ObjectType = PagedObjectType.TaskPage;
        }

        /// <summary> Initializes a new instance of TaskPage. </summary>
        /// <param name="objectType"> Paged Model types. </param>
        /// <param name="metadata"></param>
        /// <param name="content"></param>
        internal TaskPage(PagedObjectType objectType, PageMetadata metadata, IReadOnlyList<TaskPageItem> content) : base(objectType, metadata)
        {
            Content = content;
            ObjectType = objectType;
        }

        /// <summary> Gets the content. </summary>
        public IReadOnlyList<TaskPageItem> Content { get; }
    }
}
