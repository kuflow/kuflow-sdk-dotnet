// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace KuFlow.Rest.Models
{
    /// <summary> Process state. </summary>
    public readonly partial struct ProcessState : IEquatable<ProcessState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProcessState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProcessState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RunningValue = "RUNNING";
        private const string CompletedValue = "COMPLETED";
        private const string CancelledValue = "CANCELLED";

        /// <summary> RUNNING. </summary>
        public static ProcessState Running { get; } = new ProcessState(RunningValue);
        /// <summary> COMPLETED. </summary>
        public static ProcessState Completed { get; } = new ProcessState(CompletedValue);
        /// <summary> CANCELLED. </summary>
        public static ProcessState Cancelled { get; } = new ProcessState(CancelledValue);
        /// <summary> Determines if two <see cref="ProcessState"/> values are the same. </summary>
        public static bool operator ==(ProcessState left, ProcessState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProcessState"/> values are not the same. </summary>
        public static bool operator !=(ProcessState left, ProcessState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProcessState"/>. </summary>
        public static implicit operator ProcessState(string value) => new ProcessState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProcessState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProcessState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
