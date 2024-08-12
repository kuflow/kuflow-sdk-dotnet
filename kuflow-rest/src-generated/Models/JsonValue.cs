// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace KuFlow.Rest.Models
{
    /// <summary> Json value. </summary>
    public partial class JsonValue
    {
        /// <summary> Initializes a new instance of <see cref="JsonValue"/>. </summary>
        /// <param name="value"> json value filled that complain with the related json schema. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JsonValue(IDictionary<string, object> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
            Errors = new ChangeTrackingList<JsonValueError>();
        }

        /// <summary> Initializes a new instance of <see cref="JsonValue"/>. </summary>
        /// <param name="valid"> true if the data complain the related json schema. </param>
        /// <param name="value"> json value filled that complain with the related json schema. </param>
        /// <param name="errors"></param>
        internal JsonValue(bool? valid, IDictionary<string, object> value, IReadOnlyList<JsonValueError> errors)
        {
            Valid = valid;
            Value = value;
            Errors = errors;
        }

        /// <summary> true if the data complain the related json schema. </summary>
        public bool? Valid { get; }
        /// <summary> json value filled that complain with the related json schema. </summary>
        public IDictionary<string, object> Value { get; }
        /// <summary> Gets the errors. </summary>
        public IReadOnlyList<JsonValueError> Errors { get; }
    }
}
