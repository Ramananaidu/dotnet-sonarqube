// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class LoadBalancerFrontendIPConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties");
            writer.WriteObjectValue(Properties);
            writer.WriteEndObject();
        }

        internal static LoadBalancerFrontendIPConfiguration DeserializeLoadBalancerFrontendIPConfiguration(JsonElement element)
        {
            string name = default;
            LoadBalancerFrontendIPConfigurationProperties properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    properties = LoadBalancerFrontendIPConfigurationProperties.DeserializeLoadBalancerFrontendIPConfigurationProperties(property.Value);
                    continue;
                }
            }
            return new LoadBalancerFrontendIPConfiguration(name, properties);
        }
    }
}
