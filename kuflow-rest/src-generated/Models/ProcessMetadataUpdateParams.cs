// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    /// <summary> Params to save metadata data. </summary>
    public partial class ProcessMetadataUpdateParams
    {
        /// <summary> Initializes a new instance of <see cref="ProcessMetadataUpdateParams"/>. </summary>
        /// <param name="metadata"> Json value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadata"/> is null. </exception>
        public ProcessMetadataUpdateParams(JsonValue metadata)
        {
            Argument.AssertNotNull(metadata, nameof(metadata));

            Metadata = metadata;
        }

        /// <summary> Json value. </summary>
        public JsonValue Metadata { get; }
    }
}