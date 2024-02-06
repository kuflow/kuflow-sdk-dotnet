// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace KuFlow.Rest.Models
{
    /// <summary> The UnknownProcessElementValue. </summary>
    internal partial class UnknownProcessElementValue : ProcessElementValue
    {
        /// <summary> Initializes a new instance of <see cref="UnknownProcessElementValue"/>. </summary>
        /// <param name="valid"></param>
        /// <param name="type"> Process element value types. </param>
        internal UnknownProcessElementValue(bool? valid, ProcessElementValueType type) : base(valid, type)
        {
            Type = type;
        }
    }
}