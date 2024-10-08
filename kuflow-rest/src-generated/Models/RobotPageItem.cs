// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    /// <summary> The RobotPageItem. </summary>
    public partial class RobotPageItem : AbstractAudited
    {
        /// <summary> Initializes a new instance of <see cref="RobotPageItem"/>. </summary>
        /// <param name="id"> Robot ID. </param>
        /// <param name="code"> Robot Code. </param>
        /// <param name="name"> Robot name. </param>
        /// <param name="sourceType"> Robot source type. </param>
        /// <param name="sourceFile"> Robot source type. </param>
        /// <param name="tenantId"> Tenant ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/>, <paramref name="name"/> or <paramref name="sourceFile"/> is null. </exception>
        internal RobotPageItem(Guid id, string code, string name, RobotSourceType sourceType, RobotSourceFile sourceFile, Guid tenantId)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(sourceFile, nameof(sourceFile));

            Id = id;
            Code = code;
            Name = name;
            SourceType = sourceType;
            SourceFile = sourceFile;
            TenantId = tenantId;
        }

        /// <summary> Initializes a new instance of <see cref="RobotPageItem"/>. </summary>
        /// <param name="createdBy"> Who create this model. </param>
        /// <param name="createdAt"> When this model was created. </param>
        /// <param name="lastModifiedBy"> Who was last update this model. </param>
        /// <param name="lastModifiedAt"> When this model type was last updated. </param>
        /// <param name="id"> Robot ID. </param>
        /// <param name="code"> Robot Code. </param>
        /// <param name="name"> Robot name. </param>
        /// <param name="description"> Robot description. </param>
        /// <param name="sourceType"> Robot source type. </param>
        /// <param name="sourceFile"> Robot source type. </param>
        /// <param name="tenantId"> Tenant ID. </param>
        internal RobotPageItem(Guid? createdBy, DateTimeOffset? createdAt, Guid? lastModifiedBy, DateTimeOffset? lastModifiedAt, Guid id, string code, string name, string description, RobotSourceType sourceType, RobotSourceFile sourceFile, Guid tenantId) : base(createdBy, createdAt, lastModifiedBy, lastModifiedAt)
        {
            Id = id;
            Code = code;
            Name = name;
            Description = description;
            SourceType = sourceType;
            SourceFile = sourceFile;
            TenantId = tenantId;
        }

        /// <summary> Robot ID. </summary>
        public Guid Id { get; }
        /// <summary> Robot Code. </summary>
        public string Code { get; }
        /// <summary> Robot name. </summary>
        public string Name { get; }
        /// <summary> Robot description. </summary>
        public string Description { get; }
        /// <summary> Robot source type. </summary>
        public RobotSourceType SourceType { get; }
        /// <summary> Robot source type. </summary>
        public RobotSourceFile SourceFile { get; }
        /// <summary> Tenant ID. </summary>
        public Guid TenantId { get; }
    }
}
