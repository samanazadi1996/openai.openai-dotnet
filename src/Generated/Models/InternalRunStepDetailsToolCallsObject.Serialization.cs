// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants;

internal partial class InternalRunStepDetailsToolCallsObject : IJsonModel<InternalRunStepDetailsToolCallsObject>
{
    void IJsonModel<InternalRunStepDetailsToolCallsObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsObject>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsObject)} does not support writing '{format}' format.");
        }

        writer.WriteStartObject();
        if (SerializedAdditionalRawData?.ContainsKey("tool_calls") != true)
        {
            writer.WritePropertyName("tool_calls"u8);
            writer.WriteStartArray();
            foreach (var item in InternalToolCalls)
            {
                writer.WriteObjectValue<RunStepToolCall>(item, options);
            }
            writer.WriteEndArray();
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

    InternalRunStepDetailsToolCallsObject IJsonModel<InternalRunStepDetailsToolCallsObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsObject>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsObject)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeInternalRunStepDetailsToolCallsObject(document.RootElement, options);
    }

    internal static InternalRunStepDetailsToolCallsObject DeserializeInternalRunStepDetailsToolCallsObject(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        IReadOnlyList<RunStepToolCall> toolCalls = default;
        string type = default;
        IDictionary<string, BinaryData> serializedAdditionalRawData = default;
        Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("tool_calls"u8))
            {
                List<RunStepToolCall> array = new List<RunStepToolCall>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    array.Add(RunStepToolCall.DeserializeRunStepToolCall(item, options));
                }
                toolCalls = array;
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
        return new InternalRunStepDetailsToolCallsObject(type, serializedAdditionalRawData, toolCalls);
    }

    BinaryData IPersistableModel<InternalRunStepDetailsToolCallsObject>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsObject>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsObject)} does not support writing '{options.Format}' format.");
        }
    }

    InternalRunStepDetailsToolCallsObject IPersistableModel<InternalRunStepDetailsToolCallsObject>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsObject>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeInternalRunStepDetailsToolCallsObject(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsObject)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<InternalRunStepDetailsToolCallsObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static new InternalRunStepDetailsToolCallsObject FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeInternalRunStepDetailsToolCallsObject(document.RootElement);
    }

    internal override BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}