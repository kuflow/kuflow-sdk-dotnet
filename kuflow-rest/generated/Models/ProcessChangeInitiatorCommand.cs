// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    /// <summary> Command to change the process initiator, only one option is required. </summary>
    public partial class ProcessChangeInitiatorCommand
    {
        /// <summary> Initializes a new instance of ProcessChangeInitiatorCommand. </summary>
        public ProcessChangeInitiatorCommand()
        {
        }

        /// <summary> Gets or sets the principal id. </summary>
        public Guid? PrincipalId { get; set; }
        /// <summary> Gets or sets the email. </summary>
        public string Email { get; set; }
    }
}
