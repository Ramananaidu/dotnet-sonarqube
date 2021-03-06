// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceBus.Models
{
    internal static partial class ServiceBusSkuTierExtensions
    {
        public static string ToSerialString(this ServiceBusSkuTier value) => value switch
        {
            ServiceBusSkuTier.Basic => "Basic",
            ServiceBusSkuTier.Standard => "Standard",
            ServiceBusSkuTier.Premium => "Premium",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ServiceBusSkuTier value.")
        };

        public static ServiceBusSkuTier ToServiceBusSkuTier(this string value)
        {
            if (string.Equals(value, "Basic", StringComparison.InvariantCultureIgnoreCase)) return ServiceBusSkuTier.Basic;
            if (string.Equals(value, "Standard", StringComparison.InvariantCultureIgnoreCase)) return ServiceBusSkuTier.Standard;
            if (string.Equals(value, "Premium", StringComparison.InvariantCultureIgnoreCase)) return ServiceBusSkuTier.Premium;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ServiceBusSkuTier value.");
        }
    }
}
