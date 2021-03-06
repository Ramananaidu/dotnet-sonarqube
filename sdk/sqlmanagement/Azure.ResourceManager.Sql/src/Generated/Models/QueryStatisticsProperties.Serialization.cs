// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class QueryStatisticsProperties
    {
        internal static QueryStatisticsProperties DeserializeQueryStatisticsProperties(JsonElement element)
        {
            Optional<string> databaseName = default;
            Optional<string> queryId = default;
            Optional<string> startTime = default;
            Optional<string> endTime = default;
            Optional<IReadOnlyList<QueryMetricInterval>> intervals = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryId"))
                {
                    queryId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    endTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("intervals"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<QueryMetricInterval> array = new List<QueryMetricInterval>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryMetricInterval.DeserializeQueryMetricInterval(item));
                    }
                    intervals = array;
                    continue;
                }
            }
            return new QueryStatisticsProperties(databaseName.Value, queryId.Value, startTime.Value, endTime.Value, Optional.ToList(intervals));
        }
    }
}
