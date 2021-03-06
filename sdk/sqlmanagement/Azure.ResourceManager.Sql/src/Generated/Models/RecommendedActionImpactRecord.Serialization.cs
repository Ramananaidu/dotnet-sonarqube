// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class RecommendedActionImpactRecord
    {
        internal static RecommendedActionImpactRecord DeserializeRecommendedActionImpactRecord(JsonElement element)
        {
            Optional<string> dimensionName = default;
            Optional<string> unit = default;
            Optional<double> absoluteValue = default;
            Optional<double> changeValueAbsolute = default;
            Optional<double> changeValueRelative = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dimensionName"))
                {
                    dimensionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("absoluteValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    absoluteValue = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("changeValueAbsolute"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    changeValueAbsolute = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("changeValueRelative"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    changeValueRelative = property.Value.GetDouble();
                    continue;
                }
            }
            return new RecommendedActionImpactRecord(dimensionName.Value, unit.Value, Optional.ToNullable(absoluteValue), Optional.ToNullable(changeValueAbsolute), Optional.ToNullable(changeValueRelative));
        }
    }
}
