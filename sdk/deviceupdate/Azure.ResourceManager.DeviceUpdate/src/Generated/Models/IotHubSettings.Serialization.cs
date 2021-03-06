// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class IotHubSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resourceId");
            writer.WriteStringValue(ResourceId);
            if (Optional.IsDefined(IoTHubConnectionString))
            {
                writer.WritePropertyName("ioTHubConnectionString");
                writer.WriteStringValue(IoTHubConnectionString);
            }
            if (Optional.IsDefined(EventHubConnectionString))
            {
                writer.WritePropertyName("eventHubConnectionString");
                writer.WriteStringValue(EventHubConnectionString);
            }
            writer.WriteEndObject();
        }

        internal static IotHubSettings DeserializeIotHubSettings(JsonElement element)
        {
            string resourceId = default;
            Optional<string> ioTHubConnectionString = default;
            Optional<string> eventHubConnectionString = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ioTHubConnectionString"))
                {
                    ioTHubConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventHubConnectionString"))
                {
                    eventHubConnectionString = property.Value.GetString();
                    continue;
                }
            }
            return new IotHubSettings(resourceId, ioTHubConnectionString.Value, eventHubConnectionString.Value);
        }
    }
}
