// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class ApplicationDeploymentPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("deploymentMode");
            writer.WriteStringValue(DeploymentMode.ToString());
            writer.WriteEndObject();
        }

        internal static ApplicationDeploymentPolicy DeserializeApplicationDeploymentPolicy(JsonElement element)
        {
            DeploymentMode deploymentMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentMode"))
                {
                    deploymentMode = new DeploymentMode(property.Value.GetString());
                    continue;
                }
            }
            return new ApplicationDeploymentPolicy(deploymentMode);
        }
    }
}
