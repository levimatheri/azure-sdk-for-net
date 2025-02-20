// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Describes what kind of security agent provisioning action to take. </summary>
    public readonly partial struct AutoProvision : IEquatable<AutoProvision>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutoProvision"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutoProvision(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnValue = "On";
        private const string OffValue = "Off";

        /// <summary> Install missing security agent on VMs automatically. </summary>
        public static AutoProvision On { get; } = new AutoProvision(OnValue);
        /// <summary> Do not install security agent on the VMs automatically. </summary>
        public static AutoProvision Off { get; } = new AutoProvision(OffValue);
        /// <summary> Determines if two <see cref="AutoProvision"/> values are the same. </summary>
        public static bool operator ==(AutoProvision left, AutoProvision right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutoProvision"/> values are not the same. </summary>
        public static bool operator !=(AutoProvision left, AutoProvision right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AutoProvision"/>. </summary>
        public static implicit operator AutoProvision(string value) => new AutoProvision(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutoProvision other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutoProvision other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
