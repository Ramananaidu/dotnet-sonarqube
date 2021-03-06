// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The ProviderStackOsType. </summary>
    public readonly partial struct ProviderStackOsType : IEquatable<ProviderStackOsType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProviderStackOsType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProviderStackOsType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";
        private const string LinuxValue = "Linux";
        private const string AllValue = "All";

        /// <summary> Windows. </summary>
        public static ProviderStackOsType Windows { get; } = new ProviderStackOsType(WindowsValue);
        /// <summary> Linux. </summary>
        public static ProviderStackOsType Linux { get; } = new ProviderStackOsType(LinuxValue);
        /// <summary> All. </summary>
        public static ProviderStackOsType All { get; } = new ProviderStackOsType(AllValue);
        /// <summary> Determines if two <see cref="ProviderStackOsType"/> values are the same. </summary>
        public static bool operator ==(ProviderStackOsType left, ProviderStackOsType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProviderStackOsType"/> values are not the same. </summary>
        public static bool operator !=(ProviderStackOsType left, ProviderStackOsType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProviderStackOsType"/>. </summary>
        public static implicit operator ProviderStackOsType(string value) => new ProviderStackOsType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProviderStackOsType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProviderStackOsType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
