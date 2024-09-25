// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Chat;

public partial class FunctionChatMessage : IJsonModel<FunctionChatMessage>
{
    FunctionChatMessage IJsonModel<FunctionChatMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<FunctionChatMessage>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(FunctionChatMessage)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeFunctionChatMessage(document.RootElement, options);
    }

    internal static FunctionChatMessage DeserializeFunctionChatMessage(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        string name = default;
        ChatMessageRole role = default;
        IList<ChatMessageContentPart> content = default;
        IDictionary<string, BinaryData> serializedAdditionalRawData = default;
        Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("name"u8))
            {
                name = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("role"u8))
            {
                role = property.Value.GetString().ToChatMessageRole();
                continue;
            }
            if (property.NameEquals("content"u8))
            {
                DeserializeContentValue(property, ref content);
                continue;
            }
            if (true)
            {
                rawDataDictionary ??= new Dictionary<string, BinaryData>();
                rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
        }
        serializedAdditionalRawData = rawDataDictionary;
        return new FunctionChatMessage(role, content ?? new ChangeTrackingList<ChatMessageContentPart>(), serializedAdditionalRawData, name);
    }

    BinaryData IPersistableModel<FunctionChatMessage>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<FunctionChatMessage>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(FunctionChatMessage)} does not support writing '{options.Format}' format.");
        }
    }

    FunctionChatMessage IPersistableModel<FunctionChatMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<FunctionChatMessage>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeFunctionChatMessage(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(FunctionChatMessage)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<FunctionChatMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static new FunctionChatMessage FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeFunctionChatMessage(document.RootElement);
    }

    internal override BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}