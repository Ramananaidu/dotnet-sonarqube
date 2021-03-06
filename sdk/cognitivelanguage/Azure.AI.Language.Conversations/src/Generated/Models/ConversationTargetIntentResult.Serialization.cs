// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations
{
    public partial class ConversationTargetIntentResult
    {
        internal static ConversationTargetIntentResult DeserializeConversationTargetIntentResult(JsonElement element)
        {
            Optional<ConversationResult> result = default;
            TargetKind targetKind = default;
            Optional<string> apiVersion = default;
            float confidenceScore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("result"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        result = null;
                        continue;
                    }
                    result = ConversationResult.DeserializeConversationResult(property.Value);
                    continue;
                }
                if (property.NameEquals("targetKind"))
                {
                    targetKind = new TargetKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiVersion"))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScore"))
                {
                    confidenceScore = property.Value.GetSingle();
                    continue;
                }
            }
            return new ConversationTargetIntentResult(targetKind, apiVersion.Value, confidenceScore, result.Value);
        }
    }
}
