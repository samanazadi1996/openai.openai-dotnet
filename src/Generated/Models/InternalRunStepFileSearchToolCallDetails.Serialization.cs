// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants;

internal partial class InternalRunStepFileSearchToolCallDetails : IJsonModel<InternalRunStepFileSearchToolCallDetails>
{
    void IJsonModel<InternalRunStepFileSearchToolCallDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepFileSearchToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalRunStepFileSearchToolCallDetails)} does not support writing '{format}' format.");
        }

        writer.WriteStartObject();
        if (SerializedAdditionalRawData?.ContainsKey("id") != true)
        {
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
        }
        if (SerializedAdditionalRawData?.ContainsKey("file_search") != true)
        {
            writer.WritePropertyName("file_search"u8);
            writer.WriteObjectValue(FileSearch, options);
        }
        if (SerializedAdditionalRawData?.ContainsKey("type") != true)
        {
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
        }
        if (SerializedAdditionalRawData != null)
        {
            foreach (var item in SerializedAdditionalRawData)
            {
                if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                {
                    continue;
                }
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
        }
        writer.WriteEndObject();
    }

    InternalRunStepFileSearchToolCallDetails IJsonModel<InternalRunStepFileSearchToolCallDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepFileSearchToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalRunStepFileSearchToolCallDetails)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeInternalRunStepFileSearchToolCallDetails(document.RootElement, options);
    }

    internal static InternalRunStepFileSearchToolCallDetails DeserializeInternalRunStepFileSearchToolCallDetails(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        string id = default;
        InternalRunStepDetailsToolCallsFileSearchObjectFileSearch fileSearch = default;
        string type = default;
        IDictionary<string, BinaryData> serializedAdditionalRawData = default;
        Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("id"u8))
            {
                id = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("file_search"u8))
            {
                fileSearch = InternalRunStepDetailsToolCallsFileSearchObjectFileSearch.DeserializeInternalRunStepDetailsToolCallsFileSearchObjectFileSearch(property.Value, options);
                continue;
            }
            if (property.NameEquals("type"u8))
            {
                type = property.Value.GetString();
                continue;
            }
            if (true)
            {
                rawDataDictionary ??= new Dictionary<string, BinaryData>();
                rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
        }
        serializedAdditionalRawData = rawDataDictionary;
        return new InternalRunStepFileSearchToolCallDetails(type, serializedAdditionalRawData, id, fileSearch);
    }

    BinaryData IPersistableModel<InternalRunStepFileSearchToolCallDetails>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepFileSearchToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(InternalRunStepFileSearchToolCallDetails)} does not support writing '{options.Format}' format.");
        }
    }

    InternalRunStepFileSearchToolCallDetails IPersistableModel<InternalRunStepFileSearchToolCallDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepFileSearchToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeInternalRunStepFileSearchToolCallDetails(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(InternalRunStepFileSearchToolCallDetails)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<InternalRunStepFileSearchToolCallDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static new InternalRunStepFileSearchToolCallDetails FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeInternalRunStepFileSearchToolCallDetails(document.RootElement);
    }

    internal override BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}