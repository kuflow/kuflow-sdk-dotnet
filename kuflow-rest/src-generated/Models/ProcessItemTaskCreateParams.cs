// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    /// <summary> The ProcessItemTaskCreateParams. </summary>
    public partial class ProcessItemTaskCreateParams
    {
        /// <summary> Initializes a new instance of <see cref="ProcessItemTaskCreateParams"/>. </summary>
        /// <param name="taskDefinitionCode"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="taskDefinitionCode"/> is null. </exception>
        public ProcessItemTaskCreateParams(string taskDefinitionCode)
        {
            Argument.AssertNotNull(taskDefinitionCode, nameof(taskDefinitionCode));

            TaskDefinitionCode = taskDefinitionCode;
        }

        /// <summary> Initializes a new instance of <see cref="ProcessItemTaskCreateParams"/>. </summary>
        /// <param name="taskDefinitionCode"></param>
        /// <param name="data"> Json value. </param>
        internal ProcessItemTaskCreateParams(string taskDefinitionCode, JsonValue data)
        {
            TaskDefinitionCode = taskDefinitionCode;
            Data = data;
        }

        /// <summary> Gets the task definition code. </summary>
        public string TaskDefinitionCode { get; }
        /// <summary> Json value. </summary>
        public JsonValue Data { get; set; }
    }
}
