// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    /// <summary> The TaskPageItem. </summary>
    public partial class TaskPageItem : AbstractAudited
    {
        /// <summary> Initializes a new instance of <see cref="TaskPageItem"/>. </summary>
        /// <param name="taskDefinition"> In creation task, one of 'id, version or code' is mandatory. </param>
        /// <param name="processId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="taskDefinition"/> is null. </exception>
        public TaskPageItem(TaskDefinitionSummary taskDefinition, Guid processId)
        {
            Argument.AssertNotNull(taskDefinition, nameof(taskDefinition));

            TaskDefinition = taskDefinition;
            ProcessId = processId;
            ElementValues = new ChangeTrackingDictionary<string, IList<TaskElementValue>>();
        }

        /// <summary> Initializes a new instance of <see cref="TaskPageItem"/>. </summary>
        /// <param name="objectType"> Audited object Types. </param>
        /// <param name="createdBy"> Who create this model. </param>
        /// <param name="createdAt"> When this model was created. </param>
        /// <param name="lastModifiedBy"> Who was last update this model. </param>
        /// <param name="lastModifiedAt"> When this model type was last updated. </param>
        /// <param name="id"></param>
        /// <param name="state"> Task state. </param>
        /// <param name="taskDefinition"> In creation task, one of 'id, version or code' is mandatory. </param>
        /// <param name="processId"></param>
        /// <param name="elementValues"> Task element values, en ElementValueDocument is not allowed. </param>
        /// <param name="jsonFormsValue">
        /// Json form values, used when the render type selected is JSON Forms.
        ///
        /// </param>
        /// <param name="owner"></param>
        /// <param name="tenantId"> Tenant ID. </param>
        internal TaskPageItem(AuditedObjectType? objectType, Guid? createdBy, DateTimeOffset? createdAt, Guid? lastModifiedBy, DateTimeOffset? lastModifiedAt, Guid? id, TaskState? state, TaskDefinitionSummary taskDefinition, Guid processId, IDictionary<string, IList<TaskElementValue>> elementValues, JsonFormsValue jsonFormsValue, Principal owner, Guid? tenantId) : base(objectType, createdBy, createdAt, lastModifiedBy, lastModifiedAt)
        {
            Id = id;
            State = state;
            TaskDefinition = taskDefinition;
            ProcessId = processId;
            ElementValues = elementValues;
            JsonFormsValue = jsonFormsValue;
            Owner = owner;
            TenantId = tenantId;
        }

        /// <summary> Gets or sets the id. </summary>
        public Guid? Id { get; set; }
        /// <summary> Task state. </summary>
        public TaskState? State { get; set; }
        /// <summary> In creation task, one of 'id, version or code' is mandatory. </summary>
        public TaskDefinitionSummary TaskDefinition { get; set; }
        /// <summary> Gets or sets the process id. </summary>
        public Guid ProcessId { get; set; }
        /// <summary> Task element values, en ElementValueDocument is not allowed. </summary>
        public IDictionary<string, IList<TaskElementValue>> ElementValues { get; }
        /// <summary>
        /// Json form values, used when the render type selected is JSON Forms.
        ///
        /// </summary>
        public JsonFormsValue JsonFormsValue { get; set; }
        /// <summary> Gets or sets the owner. </summary>
        public Principal Owner { get; set; }
        /// <summary> Tenant ID. </summary>
        public Guid? TenantId { get; set; }
    }
}
