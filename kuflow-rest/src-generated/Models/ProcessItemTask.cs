// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace KuFlow.Rest.Models
{
    /// <summary> The ProcessItemTask. </summary>
    public partial class ProcessItemTask
    {
        /// <summary> Initializes a new instance of <see cref="ProcessItemTask"/>. </summary>
        /// <param name="state"> Process Item Task state. </param>
        /// <param name="taskDefinition"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="taskDefinition"/> is null. </exception>
        internal ProcessItemTask(ProcessItemTaskState state, TaskDefinitionSummary taskDefinition)
        {
            Argument.AssertNotNull(taskDefinition, nameof(taskDefinition));

            State = state;
            TaskDefinition = taskDefinition;
            Logs = new ChangeTrackingList<ProcessItemTaskLog>();
        }

        /// <summary> Initializes a new instance of <see cref="ProcessItemTask"/>. </summary>
        /// <param name="state"> Process Item Task state. </param>
        /// <param name="taskDefinition"></param>
        /// <param name="data"> Json value. </param>
        /// <param name="logs"></param>
        internal ProcessItemTask(ProcessItemTaskState state, TaskDefinitionSummary taskDefinition, JsonValue data, IReadOnlyList<ProcessItemTaskLog> logs)
        {
            State = state;
            TaskDefinition = taskDefinition;
            Data = data;
            Logs = logs;
        }

        /// <summary> Process Item Task state. </summary>
        public ProcessItemTaskState State { get; }
        /// <summary> Gets the task definition. </summary>
        public TaskDefinitionSummary TaskDefinition { get; }
        /// <summary> Json value. </summary>
        public JsonValue Data { get; }
        /// <summary> Gets the logs. </summary>
        public IReadOnlyList<ProcessItemTaskLog> Logs { get; }
    }
}