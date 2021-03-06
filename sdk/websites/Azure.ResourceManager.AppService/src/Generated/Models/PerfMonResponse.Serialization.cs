// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class PerfMonResponse
    {
        internal static PerfMonResponse DeserializePerfMonResponse(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<PerfMonSet> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    data = PerfMonSet.DeserializePerfMonSet(property.Value);
                    continue;
                }
            }
            return new PerfMonResponse(code.Value, message.Value, data.Value);
        }
    }
}
