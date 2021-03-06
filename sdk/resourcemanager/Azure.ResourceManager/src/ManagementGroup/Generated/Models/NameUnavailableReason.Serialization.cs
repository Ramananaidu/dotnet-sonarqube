// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Management.Models
{
    internal static partial class NameUnavailableReasonExtensions
    {
        public static string ToSerialString(this NameUnavailableReason value) => value switch
        {
            NameUnavailableReason.Invalid => "Invalid",
            NameUnavailableReason.AlreadyExists => "AlreadyExists",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown NameUnavailableReason value.")
        };

        public static NameUnavailableReason ToNameUnavailableReason(this string value)
        {
            if (string.Equals(value, "Invalid", StringComparison.InvariantCultureIgnoreCase)) return NameUnavailableReason.Invalid;
            if (string.Equals(value, "AlreadyExists", StringComparison.InvariantCultureIgnoreCase)) return NameUnavailableReason.AlreadyExists;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown NameUnavailableReason value.");
        }
    }
}
