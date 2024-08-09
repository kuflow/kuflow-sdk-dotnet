// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    /// <summary> Params to change the process initiator, only one option is required. </summary>
    public partial class ProcessChangeInitiatorParams
    {
        /// <summary> Initializes a new instance of <see cref="ProcessChangeInitiatorParams"/>. </summary>
        public ProcessChangeInitiatorParams()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProcessChangeInitiatorParams"/>. </summary>
        /// <param name="initiatorId"></param>
        /// <param name="initiatorEmail"></param>
        internal ProcessChangeInitiatorParams(Guid? initiatorId, string initiatorEmail)
        {
            InitiatorId = initiatorId;
            InitiatorEmail = initiatorEmail;
        }

        /// <summary> Gets or sets the initiator id. </summary>
        public Guid? InitiatorId { get; set; }
        /// <summary> Gets or sets the initiator email. </summary>
        public string InitiatorEmail { get; set; }
    }
}