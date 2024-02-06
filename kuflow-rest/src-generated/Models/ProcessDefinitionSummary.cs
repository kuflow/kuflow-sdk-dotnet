// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    /// <summary> The ProcessDefinitionSummary. </summary>
    public partial class ProcessDefinitionSummary
    {
        /// <summary> Initializes a new instance of <see cref="ProcessDefinitionSummary"/>. </summary>
        /// <param name="id"></param>
        public ProcessDefinitionSummary(Guid id)
        {
            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="ProcessDefinitionSummary"/>. </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="name"></param>
        internal ProcessDefinitionSummary(Guid id, Guid? version, string name)
        {
            Id = id;
            Version = version;
            Name = name;
        }

        /// <summary> Gets or sets the id. </summary>
        public Guid Id { get; set; }
        /// <summary> Gets or sets the version. </summary>
        public Guid? Version { get; set; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
    }
}