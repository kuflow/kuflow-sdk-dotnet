// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    /// <summary> The TaskDeleteElementCommand. </summary>
    public partial class TaskDeleteElementCommand
    {
        /// <summary> Initializes a new instance of <see cref="TaskDeleteElementCommand"/>. </summary>
        /// <param name="elementDefinitionCode"> Code of task element to delete. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="elementDefinitionCode"/> is null. </exception>
        public TaskDeleteElementCommand(string elementDefinitionCode)
        {
            Argument.AssertNotNull(elementDefinitionCode, nameof(elementDefinitionCode));

            ElementDefinitionCode = elementDefinitionCode;
        }

        /// <summary> Code of task element to delete. </summary>
        public string ElementDefinitionCode { get; }
    }
}
