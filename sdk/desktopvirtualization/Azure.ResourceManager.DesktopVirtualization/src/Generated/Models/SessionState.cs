// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> State of user session. </summary>
    public readonly partial struct SessionState : IEquatable<SessionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SessionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SessionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string ActiveValue = "Active";
        private const string DisconnectedValue = "Disconnected";
        private const string PendingValue = "Pending";
        private const string LogOffValue = "LogOff";
        private const string UserProfileDiskMountedValue = "UserProfileDiskMounted";

        /// <summary> Unknown. </summary>
        public static SessionState Unknown { get; } = new SessionState(UnknownValue);
        /// <summary> Active. </summary>
        public static SessionState Active { get; } = new SessionState(ActiveValue);
        /// <summary> Disconnected. </summary>
        public static SessionState Disconnected { get; } = new SessionState(DisconnectedValue);
        /// <summary> Pending. </summary>
        public static SessionState Pending { get; } = new SessionState(PendingValue);
        /// <summary> LogOff. </summary>
        public static SessionState LogOff { get; } = new SessionState(LogOffValue);
        /// <summary> UserProfileDiskMounted. </summary>
        public static SessionState UserProfileDiskMounted { get; } = new SessionState(UserProfileDiskMountedValue);
        /// <summary> Determines if two <see cref="SessionState"/> values are the same. </summary>
        public static bool operator ==(SessionState left, SessionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SessionState"/> values are not the same. </summary>
        public static bool operator !=(SessionState left, SessionState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SessionState"/>. </summary>
        public static implicit operator SessionState(string value) => new SessionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SessionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SessionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
