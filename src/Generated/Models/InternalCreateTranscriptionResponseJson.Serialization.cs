// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Audio;

internal partial class InternalCreateTranscriptionResponseJson : IJsonModel<InternalCreateTranscriptionResponseJson>
{
    void IJsonModel<InternalCreateTranscriptionResponseJson>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateTranscriptionResponseJson>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalCreateTranscriptionResponseJson)} does not support writing '{format}' format.");
        }

        writer.WriteStartObject();
        if (SerializedAdditionalRawData?.ContainsKey("text") != true)
        {
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
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

    InternalCreateTranscriptionResponseJson IJsonModel<InternalCreateTranscriptionResponseJson>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateTranscriptionResponseJson>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalCreateTranscriptionResponseJson)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeInternalCreateTranscriptionResponseJson(document.RootElement, options);
    }

    internal static InternalCreateTranscriptionResponseJson DeserializeInternalCreateTranscriptionResponseJson(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        string text = default;
        IDictionary<string, BinaryData> serializedAdditionalRawData = default;
        Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("text"u8))
            {
                text = property.Value.GetString();
                continue;
            }
            if (true)
            {
                rawDataDictionary ??= new Dictionary<string, BinaryData>();
                rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
        }
        serializedAdditionalRawData = rawDataDictionary;
        return new InternalCreateTranscriptionResponseJson(text, serializedAdditionalRawData);
    }

    BinaryData IPersistableModel<InternalCreateTranscriptionResponseJson>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateTranscriptionResponseJson>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(InternalCreateTranscriptionResponseJson)} does not support writing '{options.Format}' format.");
        }
    }

    InternalCreateTranscriptionResponseJson IPersistableModel<InternalCreateTranscriptionResponseJson>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateTranscriptionResponseJson>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeInternalCreateTranscriptionResponseJson(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(InternalCreateTranscriptionResponseJson)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<InternalCreateTranscriptionResponseJson>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static InternalCreateTranscriptionResponseJson FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeInternalCreateTranscriptionResponseJson(document.RootElement);
    }

    internal virtual BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}