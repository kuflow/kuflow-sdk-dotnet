// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    /// <summary>
    /// Json form values, used when the render type selected is JSON Forms.
    ///
    /// </summary>
    public partial class JsonFormsValue
    {
        /// <summary> Initializes a new instance of <see cref="JsonFormsValue"/>. </summary>
        public JsonFormsValue()
        {
            Data = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="JsonFormsValue"/>. </summary>
        /// <param name="valid"> true if the data complain the related json schema. </param>
        /// <param name="data"> json value filled that complain with the related json schema. </param>
        internal JsonFormsValue(bool? valid, IDictionary<string, object> data)
        {
            Valid = valid;
            Data = data;
        }

        /// <summary> true if the data complain the related json schema. </summary>
        public bool? Valid { get; set; }
        /// <summary> json value filled that complain with the related json schema. </summary>
        public IDictionary<string, object> Data { get; }
    }
}
