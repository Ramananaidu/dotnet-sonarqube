// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The storage account type used to store backups for this database. </summary>
    public readonly partial struct CurrentBackupStorageRedundancy : IEquatable<CurrentBackupStorageRedundancy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CurrentBackupStorageRedundancy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CurrentBackupStorageRedundancy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GeoValue = "Geo";
        private const string LocalValue = "Local";
        private const string ZoneValue = "Zone";

        /// <summary> Geo. </summary>
        public static CurrentBackupStorageRedundancy Geo { get; } = new CurrentBackupStorageRedundancy(GeoValue);
        /// <summary> Local. </summary>
        public static CurrentBackupStorageRedundancy Local { get; } = new CurrentBackupStorageRedundancy(LocalValue);
        /// <summary> Zone. </summary>
        public static CurrentBackupStorageRedundancy Zone { get; } = new CurrentBackupStorageRedundancy(ZoneValue);
        /// <summary> Determines if two <see cref="CurrentBackupStorageRedundancy"/> values are the same. </summary>
        public static bool operator ==(CurrentBackupStorageRedundancy left, CurrentBackupStorageRedundancy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CurrentBackupStorageRedundancy"/> values are not the same. </summary>
        public static bool operator !=(CurrentBackupStorageRedundancy left, CurrentBackupStorageRedundancy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CurrentBackupStorageRedundancy"/>. </summary>
        public static implicit operator CurrentBackupStorageRedundancy(string value) => new CurrentBackupStorageRedundancy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CurrentBackupStorageRedundancy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CurrentBackupStorageRedundancy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
