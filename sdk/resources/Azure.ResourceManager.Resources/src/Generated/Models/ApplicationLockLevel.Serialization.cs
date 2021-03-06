// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    internal static partial class ApplicationLockLevelExtensions
    {
        public static string ToSerialString(this ApplicationLockLevel value) => value switch
        {
            ApplicationLockLevel.None => "None",
            ApplicationLockLevel.CanNotDelete => "CanNotDelete",
            ApplicationLockLevel.ReadOnly => "ReadOnly",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ApplicationLockLevel value.")
        };

        public static ApplicationLockLevel ToApplicationLockLevel(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return ApplicationLockLevel.None;
            if (string.Equals(value, "CanNotDelete", StringComparison.InvariantCultureIgnoreCase)) return ApplicationLockLevel.CanNotDelete;
            if (string.Equals(value, "ReadOnly", StringComparison.InvariantCultureIgnoreCase)) return ApplicationLockLevel.ReadOnly;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ApplicationLockLevel value.");
        }
    }
}
