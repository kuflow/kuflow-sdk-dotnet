// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
    /// <summary> The ProcessItemTaskLog. </summary>
    public partial class ProcessItemTaskLog
    {
        /// <summary> Initializes a new instance of <see cref="ProcessItemTaskLog"/>. </summary>
        /// <param name="id"></param>
        /// <param name="timestamp"> When this model was created. </param>
        /// <param name="message"></param>
        /// <param name="level"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal ProcessItemTaskLog(Guid id, DateTimeOffset timestamp, string message, ProcessItemTaskLogLevel level)
        {
            Argument.AssertNotNull(message, nameof(message));

            Id = id;
            Timestamp = timestamp;
            Message = message;
            Level = level;
        }

        /// <summary> Gets the id. </summary>
        public Guid Id { get; }
        /// <summary> When this model was created. </summary>
        public DateTimeOffset Timestamp { get; }
        /// <summary> Gets the message. </summary>
        public string Message { get; }
        /// <summary> Gets the level. </summary>
        public ProcessItemTaskLogLevel Level { get; }
    }
}