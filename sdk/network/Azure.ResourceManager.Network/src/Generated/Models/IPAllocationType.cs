// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> IpAllocation type. </summary>
    public readonly partial struct IPAllocationType : IEquatable<IPAllocationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IPAllocationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IPAllocationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UndefinedValue = "Undefined";
        private const string HypernetValue = "Hypernet";

        /// <summary> Undefined. </summary>
        public static IPAllocationType Undefined { get; } = new IPAllocationType(UndefinedValue);
        /// <summary> Hypernet. </summary>
        public static IPAllocationType Hypernet { get; } = new IPAllocationType(HypernetValue);
        /// <summary> Determines if two <see cref="IPAllocationType"/> values are the same. </summary>
        public static bool operator ==(IPAllocationType left, IPAllocationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IPAllocationType"/> values are not the same. </summary>
        public static bool operator !=(IPAllocationType left, IPAllocationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IPAllocationType"/>. </summary>
        public static implicit operator IPAllocationType(string value) => new IPAllocationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IPAllocationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IPAllocationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
