// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace KuFlow.Rest.Models
{
    /// <summary> The operation to perform. </summary>
    public readonly partial struct JsonPatchOperationType : IEquatable<JsonPatchOperationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JsonPatchOperationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JsonPatchOperationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AddValue = "add";
        private const string RemoveValue = "remove";
        private const string ReplaceValue = "replace";
        private const string MoveValue = "move";
        private const string CopyValue = "copy";
        private const string TestValue = "test";

        /// <summary> add. </summary>
        public static JsonPatchOperationType Add { get; } = new JsonPatchOperationType(AddValue);
        /// <summary> remove. </summary>
        public static JsonPatchOperationType Remove { get; } = new JsonPatchOperationType(RemoveValue);
        /// <summary> replace. </summary>
        public static JsonPatchOperationType Replace { get; } = new JsonPatchOperationType(ReplaceValue);
        /// <summary> move. </summary>
        public static JsonPatchOperationType Move { get; } = new JsonPatchOperationType(MoveValue);
        /// <summary> copy. </summary>
        public static JsonPatchOperationType Copy { get; } = new JsonPatchOperationType(CopyValue);
        /// <summary> test. </summary>
        public static JsonPatchOperationType Test { get; } = new JsonPatchOperationType(TestValue);
        /// <summary> Determines if two <see cref="JsonPatchOperationType"/> values are the same. </summary>
        public static bool operator ==(JsonPatchOperationType left, JsonPatchOperationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JsonPatchOperationType"/> values are not the same. </summary>
        public static bool operator !=(JsonPatchOperationType left, JsonPatchOperationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JsonPatchOperationType"/>. </summary>
        public static implicit operator JsonPatchOperationType(string value) => new JsonPatchOperationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JsonPatchOperationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JsonPatchOperationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
