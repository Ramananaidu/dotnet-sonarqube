// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class ProvisioningStateExtensions
    {
        public static string ToSerialString(this ProvisioningState value) => value switch
        {
            ProvisioningState.Succeeded => "Succeeded",
            ProvisioningState.Failed => "Failed",
            ProvisioningState.Canceled => "Canceled",
            ProvisioningState.InProgress => "InProgress",
            ProvisioningState.Deleting => "Deleting",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProvisioningState value.")
        };

        public static ProvisioningState ToProvisioningState(this string value)
        {
            if (string.Equals(value, "Succeeded", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.Succeeded;
            if (string.Equals(value, "Failed", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.Failed;
            if (string.Equals(value, "Canceled", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.Canceled;
            if (string.Equals(value, "InProgress", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.InProgress;
            if (string.Equals(value, "Deleting", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.Deleting;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProvisioningState value.");
        }
    }
}
