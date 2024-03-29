// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    /// <summary> The ProcessPageItem. </summary>
    public partial class ProcessPageItem : AbstractAudited
    {
        /// <summary> Initializes a new instance of <see cref="ProcessPageItem"/>. </summary>
        /// <param name="processDefinition"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="processDefinition"/> is null. </exception>
        public ProcessPageItem(ProcessDefinitionSummary processDefinition)
        {
            Argument.AssertNotNull(processDefinition, nameof(processDefinition));

            ProcessDefinition = processDefinition;
            ElementValues = new ChangeTrackingDictionary<string, IList<ProcessElementValue>>();
        }

        /// <summary> Initializes a new instance of <see cref="ProcessPageItem"/>. </summary>
        /// <param name="objectType"> Audited object Types. </param>
        /// <param name="createdBy"> Who create this model. </param>
        /// <param name="createdAt"> When this model was created. </param>
        /// <param name="lastModifiedBy"> Who was last update this model. </param>
        /// <param name="lastModifiedAt"> When this model type was last updated. </param>
        /// <param name="id"> Process ID. </param>
        /// <param name="subject"> Process subject. </param>
        /// <param name="state"> Process state. </param>
        /// <param name="processDefinition"></param>
        /// <param name="elementValues"> Process element values, an ElementValueDocument is not allowed. </param>
        /// <param name="initiator"></param>
        /// <param name="tenantId"> Tenant ID. </param>
        internal ProcessPageItem(AuditedObjectType? objectType, Guid? createdBy, DateTimeOffset? createdAt, Guid? lastModifiedBy, DateTimeOffset? lastModifiedAt, Guid? id, string subject, ProcessState? state, ProcessDefinitionSummary processDefinition, IDictionary<string, IList<ProcessElementValue>> elementValues, Principal initiator, Guid? tenantId) : base(objectType, createdBy, createdAt, lastModifiedBy, lastModifiedAt)
        {
            Id = id;
            Subject = subject;
            State = state;
            ProcessDefinition = processDefinition;
            ElementValues = elementValues;
            Initiator = initiator;
            TenantId = tenantId;
        }

        /// <summary> Process ID. </summary>
        public Guid? Id { get; set; }
        /// <summary> Process subject. </summary>
        public string Subject { get; set; }
        /// <summary> Process state. </summary>
        public ProcessState? State { get; set; }
        /// <summary> Gets or sets the process definition. </summary>
        public ProcessDefinitionSummary ProcessDefinition { get; set; }
        /// <summary> Process element values, an ElementValueDocument is not allowed. </summary>
        public IDictionary<string, IList<ProcessElementValue>> ElementValues { get; }
        /// <summary> Gets or sets the initiator. </summary>
        public Principal Initiator { get; set; }
        /// <summary> Tenant ID. </summary>
        public Guid? TenantId { get; set; }
    }
}
