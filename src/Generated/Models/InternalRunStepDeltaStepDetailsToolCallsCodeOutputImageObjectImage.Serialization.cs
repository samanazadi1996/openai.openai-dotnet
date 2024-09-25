// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants;

internal partial class InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage : IJsonModel<InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage>
{
    void IJsonModel<InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage)} does not support writing '{format}' format.");
        }

        writer.WriteStartObject();
        if (SerializedAdditionalRawData?.ContainsKey("file_id") != true && Optional.IsDefined(FileId))
        {
            writer.WritePropertyName("file_id"u8);
            writer.WriteStringValue(FileId);
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

    InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage IJsonModel<InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeInternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage(document.RootElement, options);
    }

    internal static InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage DeserializeInternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        string fileId = default;
        IDictionary<string, BinaryData> serializedAdditionalRawData = default;
        Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("file_id"u8))
            {
                fileId = property.Value.GetString();
                continue;
            }
            if (true)
            {
                rawDataDictionary ??= new Dictionary<string, BinaryData>();
                rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
        }
        serializedAdditionalRawData = rawDataDictionary;
        return new InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage(fileId, serializedAdditionalRawData);
    }

    BinaryData IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage)} does not support writing '{options.Format}' format.");
        }
    }

    InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeInternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static InternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeInternalRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage(document.RootElement);
    }

    internal virtual BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}