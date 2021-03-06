// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// The type of route this is:
    /// DEFAULT - By default, every app has routes to the local address ranges specified by RFC1918
    /// INHERITED - Routes inherited from the real Virtual Network routes
    /// STATIC - Static route set on the app only
    /// 
    /// These values will be used for syncing an app&apos;s routes with those from a Virtual Network.
    /// </summary>
    public readonly partial struct RouteType : IEquatable<RouteType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RouteType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RouteType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "DEFAULT";
        private const string InheritedValue = "INHERITED";
        private const string StaticValue = "STATIC";

        /// <summary> DEFAULT. </summary>
        public static RouteType Default { get; } = new RouteType(DefaultValue);
        /// <summary> INHERITED. </summary>
        public static RouteType Inherited { get; } = new RouteType(InheritedValue);
        /// <summary> STATIC. </summary>
        public static RouteType Static { get; } = new RouteType(StaticValue);
        /// <summary> Determines if two <see cref="RouteType"/> values are the same. </summary>
        public static bool operator ==(RouteType left, RouteType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RouteType"/> values are not the same. </summary>
        public static bool operator !=(RouteType left, RouteType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RouteType"/>. </summary>
        public static implicit operator RouteType(string value) => new RouteType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RouteType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RouteType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
