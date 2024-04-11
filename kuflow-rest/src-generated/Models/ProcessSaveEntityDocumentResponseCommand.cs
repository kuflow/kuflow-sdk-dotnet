// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    /// <summary> The ProcessSaveEntityDocumentResponseCommand. </summary>
    public partial class ProcessSaveEntityDocumentResponseCommand
    {
        /// <summary> Initializes a new instance of <see cref="ProcessSaveEntityDocumentResponseCommand"/>. </summary>
        /// <param name="value">
        /// JSON value representing the uploaded file.
        ///
        /// Example: `kuflow-file:uri=xxx-yyy-zzz;type=application/json;size=500;name=file.json;`
        ///
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ProcessSaveEntityDocumentResponseCommand(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
        }

        /// <summary>
        /// JSON value representing the uploaded file.
        ///
        /// Example: `kuflow-file:uri=xxx-yyy-zzz;type=application/json;size=500;name=file.json;`
        ///
        /// </summary>
        public string Value { get; }
    }
}
