// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    /// <summary> The Authentication. </summary>
    public partial class Authentication : AbstractAudited
    {
        /// <summary> Initializes a new instance of <see cref="Authentication"/>. </summary>
        public Authentication()
        {
            ObjectType = AuditedObjectType.Authentication;
        }

        /// <summary> Initializes a new instance of <see cref="Authentication"/>. </summary>
        /// <param name="objectType"> Identifies the concrete type of the audited model. </param>
        /// <param name="createdBy"> Who create this model. </param>
        /// <param name="createdAt"> When this model was created. </param>
        /// <param name="lastModifiedBy"> Who was last update this model. </param>
        /// <param name="lastModifiedAt"> When this model type was last updated. </param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="token"></param>
        /// <param name="expiredAt"></param>
        internal Authentication(AuditedObjectType objectType, Guid? createdBy, DateTimeOffset? createdAt, Guid? lastModifiedBy, DateTimeOffset? lastModifiedAt, Guid? id, AuthenticationType? type, string token, DateTimeOffset? expiredAt) : base(objectType, createdBy, createdAt, lastModifiedBy, lastModifiedAt)
        {
            Id = id;
            Type = type;
            Token = token;
            ExpiredAt = expiredAt;
            ObjectType = objectType;
        }

        /// <summary> Gets the id. </summary>
        public Guid? Id { get; }
        /// <summary> Gets or sets the type. </summary>
        public AuthenticationType? Type { get; set; }
        /// <summary> Gets the token. </summary>
        public string Token { get; }
        /// <summary> Gets the expired at. </summary>
        public DateTimeOffset? ExpiredAt { get; }
    }
}