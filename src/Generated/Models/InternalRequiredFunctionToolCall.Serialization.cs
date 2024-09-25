// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants;

internal partial class InternalRequiredFunctionToolCall : IJsonModel<InternalRequiredFunctionToolCall>
{
    void IJsonModel<InternalRequiredFunctionToolCall>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRequiredFunctionToolCall>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalRequiredFunctionToolCall)} does not support writing '{format}' format.");
        }

        writer.WriteStartObject();
        if (SerializedAdditionalRawData?.ContainsKey("id") != true)
        {
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
        }
        if (SerializedAdditionalRawData?.ContainsKey("type") != true)
        {
            writer.WritePropertyName("type"u8);
            writer.WriteObjectValue<object>(_type, options);
        }
        if (SerializedAdditionalRawData?.ContainsKey("function") != true)
        {
            writer.WritePropertyName("function"u8);
            writer.WriteObjectValue<InternalRunToolCallObjectFunction>(_internalFunction, options);
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

    InternalRequiredFunctionToolCall IJsonModel<InternalRequiredFunctionToolCall>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRequiredFunctionToolCall>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalRequiredFunctionToolCall)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeInternalRequiredFunctionToolCall(document.RootElement, options);
    }

    internal static InternalRequiredFunctionToolCall DeserializeInternalRequiredFunctionToolCall(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        string id = default;
        object type = default;
        InternalRunToolCallObjectFunction function = default;
        IDictionary<string, BinaryData> serializedAdditionalRawData = default;
        Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("id"u8))
            {
                id = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("type"u8))
            {
                type = property.Value.GetObject();
                continue;
            }
            if (property.NameEquals("function"u8))
            {
                function = InternalRunToolCallObjectFunction.DeserializeInternalRunToolCallObjectFunction(property.Value, options);
                continue;
            }
            if (true)
            {
                rawDataDictionary ??= new Dictionary<string, BinaryData>();
                rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
        }
        serializedAdditionalRawData = rawDataDictionary;
        return new InternalRequiredFunctionToolCall(id, type, function, serializedAdditionalRawData);
    }

    BinaryData IPersistableModel<InternalRequiredFunctionToolCall>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRequiredFunctionToolCall>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(InternalRequiredFunctionToolCall)} does not support writing '{options.Format}' format.");
        }
    }

    InternalRequiredFunctionToolCall IPersistableModel<InternalRequiredFunctionToolCall>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRequiredFunctionToolCall>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeInternalRequiredFunctionToolCall(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(InternalRequiredFunctionToolCall)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<InternalRequiredFunctionToolCall>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static InternalRequiredFunctionToolCall FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeInternalRequiredFunctionToolCall(document.RootElement);
    }

    internal virtual BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}