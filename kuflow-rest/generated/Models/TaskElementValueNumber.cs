// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace KuFlow.Rest.Models
{
    /// <summary> The TaskElementValueNumber. </summary>
    public partial class TaskElementValueNumber : TaskElementValue
    {
        /// <summary> Initializes a new instance of TaskElementValueNumber. </summary>
        public TaskElementValueNumber()
        {
            Type = TaskElementValueType.Number;
        }

        /// <summary> Initializes a new instance of TaskElementValueNumber. </summary>
        /// <param name="valid"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        internal TaskElementValueNumber(bool? valid, TaskElementValueType type, double? value) : base(valid, type)
        {
            Value = value;
            Type = type;
        }

        /// <summary> Gets or sets the value. </summary>
        public double? Value { get; set; }
    }
}
