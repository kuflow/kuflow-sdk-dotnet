// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    /// <summary> The PrincipalUser. </summary>
    public partial class PrincipalUser
    {
        /// <summary> Initializes a new instance of PrincipalUser. </summary>
        public PrincipalUser()
        {
        }

        /// <summary> Initializes a new instance of PrincipalUser. </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        internal PrincipalUser(Guid? id, string email)
        {
            Id = id;
            Email = email;
        }

        /// <summary> Gets or sets the id. </summary>
        public Guid? Id { get; set; }
        /// <summary> Gets or sets the email. </summary>
        public string Email { get; set; }
    }
}
