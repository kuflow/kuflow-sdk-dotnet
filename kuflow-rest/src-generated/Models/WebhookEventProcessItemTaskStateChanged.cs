// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    /// <summary> Process Events. </summary>
    internal partial class WebhookEventProcessItemTaskStateChanged : WebhookEvent
    {
        /// <summary> Initializes a new instance of <see cref="WebhookEventProcessItemTaskStateChanged"/>. </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="timestamp"></param>
        /// <param name="data"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        internal WebhookEventProcessItemTaskStateChanged(Guid id, string version, DateTimeOffset timestamp, WebhookEventProcessItemTaskStateChangedData data) : base(id, version, timestamp)
        {
            Argument.AssertNotNull(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            Data = data;
            Type = WebhookType.ProcessItemTaskStateChanged;
        }

        /// <summary> Initializes a new instance of <see cref="WebhookEventProcessItemTaskStateChanged"/>. </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="type"> Type of the Event. </param>
        /// <param name="timestamp"></param>
        /// <param name="data"></param>
        internal WebhookEventProcessItemTaskStateChanged(Guid id, string version, WebhookType type, DateTimeOffset timestamp, WebhookEventProcessItemTaskStateChangedData data) : base(id, version, type, timestamp)
        {
            Data = data;
            Type = type;
        }

        /// <summary> Gets the data. </summary>
        public WebhookEventProcessItemTaskStateChangedData Data { get; }
    }
}