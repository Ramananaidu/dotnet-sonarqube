// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class Descriptor : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MediaType))
            {
                writer.WritePropertyName("mediaType");
                writer.WriteStringValue(MediaType);
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size");
                writer.WriteNumberValue(Size.Value);
            }
            if (Optional.IsDefined(Digest))
            {
                writer.WritePropertyName("digest");
                writer.WriteStringValue(Digest);
            }
            if (Optional.IsCollectionDefined(Urls))
            {
                writer.WritePropertyName("urls");
                writer.WriteStartArray();
                foreach (var item in Urls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Annotations))
            {
                if (Annotations != null)
                {
                    writer.WritePropertyName("annotations");
                    writer.WriteObjectValue(Annotations);
                }
                else
                {
                    writer.WriteNull("annotations");
                }
            }
            writer.WriteEndObject();
        }

        internal static Descriptor DeserializeDescriptor(JsonElement element)
        {
            Optional<string> mediaType = default;
            Optional<long> size = default;
            Optional<string> digest = default;
            Optional<IList<string>> urls = default;
            Optional<Annotations> annotations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    size = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("digest"))
                {
                    digest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("urls"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    urls = array;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        annotations = null;
                        continue;
                    }
                    annotations = Annotations.DeserializeAnnotations(property.Value);
                    continue;
                }
            }
            return new Descriptor(mediaType.Value, Optional.ToNullable(size), digest.Value, Optional.ToList(urls), annotations.Value);
        }
    }
}
