// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI.Internal;

namespace OpenAI.Chat;

internal partial class InternalChatResponseFormatJsonSchema : IJsonModel<InternalChatResponseFormatJsonSchema>
{
    InternalChatResponseFormatJsonSchema IJsonModel<InternalChatResponseFormatJsonSchema>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalChatResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalChatResponseFormatJsonSchema)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeInternalChatResponseFormatJsonSchema(document.RootElement, options);
    }

    internal static InternalChatResponseFormatJsonSchema DeserializeInternalChatResponseFormatJsonSchema(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        InternalResponseFormatJsonSchemaJsonSchema jsonSchema = default;
        string type = default;
        IDictionary<string, BinaryData> serializedAdditionalRawData = default;
        Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("json_schema"u8))
            {
                jsonSchema = InternalResponseFormatJsonSchemaJsonSchema.DeserializeInternalResponseFormatJsonSchemaJsonSchema(property.Value, options);
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
        return new InternalChatResponseFormatJsonSchema(type, serializedAdditionalRawData, jsonSchema);
    }

    BinaryData IPersistableModel<InternalChatResponseFormatJsonSchema>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalChatResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(InternalChatResponseFormatJsonSchema)} does not support writing '{options.Format}' format.");
        }
    }

    InternalChatResponseFormatJsonSchema IPersistableModel<InternalChatResponseFormatJsonSchema>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalChatResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeInternalChatResponseFormatJsonSchema(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(InternalChatResponseFormatJsonSchema)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<InternalChatResponseFormatJsonSchema>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static new InternalChatResponseFormatJsonSchema FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeInternalChatResponseFormatJsonSchema(document.RootElement);
    }

    internal override BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}