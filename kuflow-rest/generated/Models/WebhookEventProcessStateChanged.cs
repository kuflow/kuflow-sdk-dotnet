// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    /// <summary> Process Events. </summary>
    internal partial class WebhookEventProcessStateChanged : WebhookEvent
    {
        /// <summary> Initializes a new instance of WebhookEventProcessStateChanged. </summary>
        /// <param name="id"></param>
        /// <param name="timestamp"></param>
        /// <param name="data"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        internal WebhookEventProcessStateChanged(Guid id, DateTimeOffset timestamp, WebhookEventProcessStateChangedData data) : base(id, timestamp)
        {
            Argument.AssertNotNull(data, nameof(data));

            Data = data;
            Type = WebhookType.ProcessStateChanged;
        }

        /// <summary> Gets the data. </summary>
        public WebhookEventProcessStateChangedData Data { get; }
    }
}
