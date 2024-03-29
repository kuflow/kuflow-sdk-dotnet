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
    /// <summary> The RobotPage. </summary>
    public partial class RobotPage : Page
    {
        /// <summary> Initializes a new instance of <see cref="RobotPage"/>. </summary>
        /// <param name="metadata"></param>
        /// <param name="content"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadata"/> or <paramref name="content"/> is null. </exception>
        internal RobotPage(PageMetadata metadata, IEnumerable<Robot> content) : base(metadata)
        {
            Argument.AssertNotNull(metadata, nameof(metadata));
            Argument.AssertNotNull(content, nameof(content));

            Content = content.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RobotPage"/>. </summary>
        /// <param name="objectType"> Paged Model types. </param>
        /// <param name="metadata"></param>
        /// <param name="content"></param>
        internal RobotPage(PagedObjectType? objectType, PageMetadata metadata, IReadOnlyList<Robot> content) : base(objectType, metadata)
        {
            Content = content;
        }

        /// <summary> Gets the content. </summary>
        public IReadOnlyList<Robot> Content { get; }
    }
}
