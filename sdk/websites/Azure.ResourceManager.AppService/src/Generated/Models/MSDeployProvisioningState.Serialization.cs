// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class MSDeployProvisioningStateExtensions
    {
        public static string ToSerialString(this MSDeployProvisioningState value) => value switch
        {
            MSDeployProvisioningState.Accepted => "accepted",
            MSDeployProvisioningState.Running => "running",
            MSDeployProvisioningState.Succeeded => "succeeded",
            MSDeployProvisioningState.Failed => "failed",
            MSDeployProvisioningState.Canceled => "canceled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MSDeployProvisioningState value.")
        };

        public static MSDeployProvisioningState ToMSDeployProvisioningState(this string value)
        {
            if (string.Equals(value, "accepted", StringComparison.InvariantCultureIgnoreCase)) return MSDeployProvisioningState.Accepted;
            if (string.Equals(value, "running", StringComparison.InvariantCultureIgnoreCase)) return MSDeployProvisioningState.Running;
            if (string.Equals(value, "succeeded", StringComparison.InvariantCultureIgnoreCase)) return MSDeployProvisioningState.Succeeded;
            if (string.Equals(value, "failed", StringComparison.InvariantCultureIgnoreCase)) return MSDeployProvisioningState.Failed;
            if (string.Equals(value, "canceled", StringComparison.InvariantCultureIgnoreCase)) return MSDeployProvisioningState.Canceled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MSDeployProvisioningState value.");
        }
    }
}
