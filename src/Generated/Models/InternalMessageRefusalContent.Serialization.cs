// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants;

internal partial class InternalMessageRefusalContent : IJsonModel<InternalMessageRefusalContent>
{
    InternalMessageRefusalContent IJsonModel<InternalMessageRefusalContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalMessageRefusalContent>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalMessageRefusalContent)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeInternalMessageRefusalContent(document.RootElement, options);
    }

    internal static InternalMessageRefusalContent DeserializeInternalMessageRefusalContent(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        string type = default;
        string refusal = default;
        IDictionary<string, BinaryData> serializedAdditionalRawData = default;
        Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("type"u8))
            {
                type = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("refusal"u8))
            {
                refusal = property.Value.GetString();
                continue;
            }
            if (true)
            {
                rawDataDictionary ??= new Dictionary<string, BinaryData>();
                rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
        }
        serializedAdditionalRawData = rawDataDictionary;
        return new InternalMessageRefusalContent(serializedAdditionalRawData, type, refusal);
    }

    BinaryData IPersistableModel<InternalMessageRefusalContent>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalMessageRefusalContent>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(InternalMessageRefusalContent)} does not support writing '{options.Format}' format.");
        }
    }

    InternalMessageRefusalContent IPersistableModel<InternalMessageRefusalContent>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalMessageRefusalContent>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeInternalMessageRefusalContent(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(InternalMessageRefusalContent)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<InternalMessageRefusalContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static new InternalMessageRefusalContent FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeInternalMessageRefusalContent(document.RootElement);
    }

    internal override BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}