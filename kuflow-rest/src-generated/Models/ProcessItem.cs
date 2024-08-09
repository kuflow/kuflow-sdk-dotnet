// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    /// <summary> The ProcessItem. </summary>
    public partial class ProcessItem : AbstractAudited
    {
        /// <summary> Initializes a new instance of <see cref="ProcessItem"/>. </summary>
        /// <param name="id"></param>
        /// <param name="type"> Process Item Type. </param>
        /// <param name="processId"></param>
        internal ProcessItem(Guid id, ProcessItemType type, Guid processId)
        {
            Id = id;
            Type = type;
            ProcessId = processId;
        }

        /// <summary> Initializes a new instance of <see cref="ProcessItem"/>. </summary>
        /// <param name="createdBy"> Who create this model. </param>
        /// <param name="createdAt"> When this model was created. </param>
        /// <param name="lastModifiedBy"> Who was last update this model. </param>
        /// <param name="lastModifiedAt"> When this model type was last updated. </param>
        /// <param name="id"></param>
        /// <param name="type"> Process Item Type. </param>
        /// <param name="processId"></param>
        /// <param name="ownerId"> Owner Principal ID. </param>
        /// <param name="tenantId"> Tenant ID. </param>
        /// <param name="task"></param>
        internal ProcessItem(Guid? createdBy, DateTimeOffset? createdAt, Guid? lastModifiedBy, DateTimeOffset? lastModifiedAt, Guid id, ProcessItemType type, Guid processId, Guid? ownerId, Guid? tenantId, ProcessItemTask task) : base(createdBy, createdAt, lastModifiedBy, lastModifiedAt)
        {
            Id = id;
            Type = type;
            ProcessId = processId;
            OwnerId = ownerId;
            TenantId = tenantId;
            Task = task;
        }

        /// <summary> Gets the id. </summary>
        public Guid Id { get; }
        /// <summary> Process Item Type. </summary>
        public ProcessItemType Type { get; }
        /// <summary> Gets the process id. </summary>
        public Guid ProcessId { get; }
        /// <summary> Owner Principal ID. </summary>
        public Guid? OwnerId { get; }
        /// <summary> Tenant ID. </summary>
        public Guid? TenantId { get; }
        /// <summary> Gets the task. </summary>
        public ProcessItemTask Task { get; }
    }
}