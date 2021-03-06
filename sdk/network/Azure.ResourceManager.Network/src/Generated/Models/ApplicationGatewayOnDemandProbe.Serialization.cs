// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayOnDemandProbe : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host");
                writer.WriteStringValue(Host);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout");
                writer.WriteNumberValue(Timeout.Value);
            }
            if (Optional.IsDefined(PickHostNameFromBackendHttpSettings))
            {
                writer.WritePropertyName("pickHostNameFromBackendHttpSettings");
                writer.WriteBooleanValue(PickHostNameFromBackendHttpSettings.Value);
            }
            if (Optional.IsDefined(Match))
            {
                writer.WritePropertyName("match");
                writer.WriteObjectValue(Match);
            }
            if (Optional.IsDefined(BackendAddressPool))
            {
                writer.WritePropertyName("backendAddressPool");
                JsonSerializer.Serialize(writer, BackendAddressPool);
            }
            if (Optional.IsDefined(BackendHttpSettings))
            {
                writer.WritePropertyName("backendHttpSettings");
                JsonSerializer.Serialize(writer, BackendHttpSettings);
            }
            writer.WriteEndObject();
        }
    }
}
