// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Kuflow.Rest.Models
{
    /// <summary> In creation task, one of &apos;id, version or code&apos; is mandatory. </summary>
    public partial class TaskDefinitionSummary
    {
        /// <summary> Initializes a new instance of TaskDefinitionSummary. </summary>
        public TaskDefinitionSummary()
        {
        }

        /// <summary> Initializes a new instance of TaskDefinitionSummary. </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="code"></param>
        /// <param name="name"></param>
        internal TaskDefinitionSummary(Guid? id, Guid? version, string code, string name)
        {
            Id = id;
            Version = version;
            Code = code;
            Name = name;
        }

        /// <summary> Gets or sets the id. </summary>
        public Guid? Id { get; set; }
        /// <summary> Gets or sets the version. </summary>
        public Guid? Version { get; set; }
        /// <summary> Gets or sets the code. </summary>
        public string Code { get; set; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
    }
}
