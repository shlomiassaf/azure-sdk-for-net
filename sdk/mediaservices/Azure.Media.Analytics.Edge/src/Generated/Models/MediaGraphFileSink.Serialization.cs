// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.Analytics.Edge.Models
{
    public partial class MediaGraphFileSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("baseDirectoryPath");
            writer.WriteStringValue(BaseDirectoryPath);
            writer.WritePropertyName("fileNamePattern");
            writer.WriteStringValue(FileNamePattern);
            writer.WritePropertyName("maximumSizeMiB");
            writer.WriteStringValue(MaximumSizeMiB);
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs");
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static MediaGraphFileSink DeserializeMediaGraphFileSink(JsonElement element)
        {
            string baseDirectoryPath = default;
            string fileNamePattern = default;
            string maximumSizeMiB = default;
            string type = default;
            string name = default;
            IList<MediaGraphNodeInput> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseDirectoryPath"))
                {
                    baseDirectoryPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileNamePattern"))
                {
                    fileNamePattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumSizeMiB"))
                {
                    maximumSizeMiB = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    List<MediaGraphNodeInput> array = new List<MediaGraphNodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaGraphNodeInput.DeserializeMediaGraphNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new MediaGraphFileSink(type, name, inputs, baseDirectoryPath, fileNamePattern, maximumSizeMiB);
        }
    }
}