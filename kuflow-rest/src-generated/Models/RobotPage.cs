// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace KuFlow.Rest.Models
{
    /// <summary> The RobotPage. </summary>
    public partial class RobotPage : Page
    {
        /// <summary> Initializes a new instance of <see cref="RobotPage"/>. </summary>
        /// <param name="metadata"></param>
        /// <param name="content"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadata"/> or <paramref name="content"/> is null. </exception>
        internal RobotPage(PageMetadata metadata, IEnumerable<RobotPageItem> content) : base(metadata)
        {
            Argument.AssertNotNull(metadata, nameof(metadata));
            Argument.AssertNotNull(content, nameof(content));

            Content = content.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RobotPage"/>. </summary>
        /// <param name="metadata"></param>
        /// <param name="content"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadata"/> is null. </exception>
        internal RobotPage(PageMetadata metadata, IReadOnlyList<RobotPageItem> content) : base(metadata)
        {
            Argument.AssertNotNull(metadata, nameof(metadata));

            Content = content;
        }

        /// <summary> Gets the content. </summary>
        public IReadOnlyList<RobotPageItem> Content { get; }
    }
}
