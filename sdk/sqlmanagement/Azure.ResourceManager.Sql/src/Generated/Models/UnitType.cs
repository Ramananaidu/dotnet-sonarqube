// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The unit of the metric. </summary>
    public readonly partial struct UnitType : IEquatable<UnitType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UnitType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UnitType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CountValue = "count";
        private const string BytesValue = "bytes";
        private const string SecondsValue = "seconds";
        private const string PercentValue = "percent";
        private const string CountPerSecondValue = "countPerSecond";
        private const string BytesPerSecondValue = "bytesPerSecond";

        /// <summary> count. </summary>
        public static UnitType Count { get; } = new UnitType(CountValue);
        /// <summary> bytes. </summary>
        public static UnitType Bytes { get; } = new UnitType(BytesValue);
        /// <summary> seconds. </summary>
        public static UnitType Seconds { get; } = new UnitType(SecondsValue);
        /// <summary> percent. </summary>
        public static UnitType Percent { get; } = new UnitType(PercentValue);
        /// <summary> countPerSecond. </summary>
        public static UnitType CountPerSecond { get; } = new UnitType(CountPerSecondValue);
        /// <summary> bytesPerSecond. </summary>
        public static UnitType BytesPerSecond { get; } = new UnitType(BytesPerSecondValue);
        /// <summary> Determines if two <see cref="UnitType"/> values are the same. </summary>
        public static bool operator ==(UnitType left, UnitType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UnitType"/> values are not the same. </summary>
        public static bool operator !=(UnitType left, UnitType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UnitType"/>. </summary>
        public static implicit operator UnitType(string value) => new UnitType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UnitType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UnitType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
