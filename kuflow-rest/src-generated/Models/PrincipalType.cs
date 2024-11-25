// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace KuFlow.Rest.Models
{
    /// <summary> The PrincipalType. </summary>
    public readonly partial struct PrincipalType : IEquatable<PrincipalType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PrincipalType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PrincipalType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserValue = "USER";
        private const string ApplicationValue = "APPLICATION";
        private const string SystemValue = "SYSTEM";

        /// <summary> USER. </summary>
        public static PrincipalType User { get; } = new PrincipalType(UserValue);
        /// <summary> APPLICATION. </summary>
        public static PrincipalType Application { get; } = new PrincipalType(ApplicationValue);
        /// <summary> SYSTEM. </summary>
        public static PrincipalType System { get; } = new PrincipalType(SystemValue);
        /// <summary> Determines if two <see cref="PrincipalType"/> values are the same. </summary>
        public static bool operator ==(PrincipalType left, PrincipalType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PrincipalType"/> values are not the same. </summary>
        public static bool operator !=(PrincipalType left, PrincipalType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PrincipalType"/>. </summary>
        public static implicit operator PrincipalType(string value) => new PrincipalType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PrincipalType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PrincipalType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
