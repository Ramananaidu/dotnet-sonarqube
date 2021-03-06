// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ApplicationNotificationEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("uri");
            writer.WriteStringValue(Uri.AbsoluteUri);
            writer.WriteEndObject();
        }

        internal static ApplicationNotificationEndpoint DeserializeApplicationNotificationEndpoint(JsonElement element)
        {
            Uri uri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uri"))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new ApplicationNotificationEndpoint(uri);
        }
    }
}
