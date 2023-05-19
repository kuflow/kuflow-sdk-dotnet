// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace KuFlow.Rest.Models
{
    /// <summary> The TaskElementValueDocument. </summary>
    public partial class TaskElementValueDocument : TaskElementValue
    {
        /// <summary> Initializes a new instance of TaskElementValueDocument. </summary>
        public TaskElementValueDocument()
        {
            Type = TaskElementValueType.Document;
        }

        /// <summary> Initializes a new instance of TaskElementValueDocument. </summary>
        /// <param name="valid"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        internal TaskElementValueDocument(bool? valid, TaskElementValueType type, TaskElementValueDocumentItem value) : base(valid, type)
        {
            Value = value;
            Type = type;
        }

        /// <summary> Gets or sets the value. </summary>
        public TaskElementValueDocumentItem Value { get; set; }
    }
}
