// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants;

internal partial class InternalCreateThreadAndRunRequest : IJsonModel<InternalCreateThreadAndRunRequest>
{
    void IJsonModel<InternalCreateThreadAndRunRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateThreadAndRunRequest>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalCreateThreadAndRunRequest)} does not support writing '{format}' format.");
        }

        writer.WriteStartObject();
        if (SerializedAdditionalRawData?.ContainsKey("assistant_id") != true)
        {
            writer.WritePropertyName("assistant_id"u8);
            writer.WriteStringValue(AssistantId);
        }
        if (SerializedAdditionalRawData?.ContainsKey("thread") != true && Optional.IsDefined(Thread))
        {
            writer.WritePropertyName("thread"u8);
            writer.WriteObjectValue(Thread, options);
        }
        if (SerializedAdditionalRawData?.ContainsKey("model") != true && Optional.IsDefined(Model))
        {
            if (Model != null)
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            else
            {
                writer.WriteNull("model");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("instructions") != true && Optional.IsDefined(Instructions))
        {
            if (Instructions != null)
            {
                writer.WritePropertyName("instructions"u8);
                writer.WriteStringValue(Instructions);
            }
            else
            {
                writer.WriteNull("instructions");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("tools") != true && Optional.IsCollectionDefined(Tools))
        {
            if (Tools != null)
            {
                writer.WritePropertyName("tools"u8);
                writer.WriteStartArray();
                foreach (var item in Tools)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNull("tools");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("tool_resources") != true && Optional.IsDefined(ToolResources))
        {
            if (ToolResources != null)
            {
                writer.WritePropertyName("tool_resources"u8);
                writer.WriteObjectValue<ToolResources>(ToolResources, options);
            }
            else
            {
                writer.WriteNull("tool_resources");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("metadata") != true && Optional.IsCollectionDefined(Metadata))
        {
            if (Metadata != null)
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNull("metadata");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("temperature") != true && Optional.IsDefined(Temperature))
        {
            if (Temperature != null)
            {
                writer.WritePropertyName("temperature"u8);
                writer.WriteNumberValue(Temperature.Value);
            }
            else
            {
                writer.WriteNull("temperature");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("top_p") != true && Optional.IsDefined(TopP))
        {
            if (TopP != null)
            {
                writer.WritePropertyName("top_p"u8);
                writer.WriteNumberValue(TopP.Value);
            }
            else
            {
                writer.WriteNull("top_p");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("stream") != true && Optional.IsDefined(Stream))
        {
            if (Stream != null)
            {
                writer.WritePropertyName("stream"u8);
                writer.WriteBooleanValue(Stream.Value);
            }
            else
            {
                writer.WriteNull("stream");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("max_prompt_tokens") != true && Optional.IsDefined(MaxPromptTokens))
        {
            if (MaxPromptTokens != null)
            {
                writer.WritePropertyName("max_prompt_tokens"u8);
                writer.WriteNumberValue(MaxPromptTokens.Value);
            }
            else
            {
                writer.WriteNull("max_prompt_tokens");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("max_completion_tokens") != true && Optional.IsDefined(MaxCompletionTokens))
        {
            if (MaxCompletionTokens != null)
            {
                writer.WritePropertyName("max_completion_tokens"u8);
                writer.WriteNumberValue(MaxCompletionTokens.Value);
            }
            else
            {
                writer.WriteNull("max_completion_tokens");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("truncation_strategy") != true && Optional.IsDefined(TruncationStrategy))
        {
            if (TruncationStrategy != null)
            {
                writer.WritePropertyName("truncation_strategy"u8);
                writer.WriteObjectValue(TruncationStrategy, options);
            }
            else
            {
                writer.WriteNull("truncation_strategy");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("tool_choice") != true && Optional.IsDefined(ToolChoice))
        {
            if (ToolChoice != null)
            {
                writer.WritePropertyName("tool_choice"u8);
                writer.WriteObjectValue<ToolConstraint>(ToolChoice, options);
            }
            else
            {
                writer.WriteNull("tool_choice");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("parallel_tool_calls") != true && Optional.IsDefined(ParallelToolCalls))
        {
            writer.WritePropertyName("parallel_tool_calls"u8);
            writer.WriteBooleanValue(ParallelToolCalls.Value);
        }
        if (SerializedAdditionalRawData?.ContainsKey("response_format") != true && Optional.IsDefined(ResponseFormat))
        {
            if (ResponseFormat != null)
            {
                writer.WritePropertyName("response_format"u8);
                writer.WriteObjectValue<AssistantResponseFormat>(ResponseFormat, options);
            }
            else
            {
                writer.WriteNull("response_format");
            }
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

    InternalCreateThreadAndRunRequest IJsonModel<InternalCreateThreadAndRunRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateThreadAndRunRequest>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalCreateThreadAndRunRequest)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeInternalCreateThreadAndRunRequest(document.RootElement, options);
    }

    internal static InternalCreateThreadAndRunRequest DeserializeInternalCreateThreadAndRunRequest(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        string assistantId = default;
        ThreadCreationOptions thread = default;
        string model = default;
        string instructions = default;
        IList<ToolDefinition> tools = default;
        ToolResources toolResources = default;
        IDictionary<string, string> metadata = default;
        float? temperature = default;
        float? topP = default;
        bool? stream = default;
        int? maxPromptTokens = default;
        int? maxCompletionTokens = default;
        RunTruncationStrategy truncationStrategy = default;
        ToolConstraint toolChoice = default;
        bool? parallelToolCalls = default;
        AssistantResponseFormat responseFormat = default;
        IDictionary<string, BinaryData> serializedAdditionalRawData = default;
        Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("assistant_id"u8))
            {
                assistantId = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("thread"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                thread = ThreadCreationOptions.DeserializeThreadCreationOptions(property.Value, options);
                continue;
            }
            if (property.NameEquals("model"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    model = null;
                    continue;
                }
                model = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("instructions"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    instructions = null;
                    continue;
                }
                instructions = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("tools"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                List<ToolDefinition> array = new List<ToolDefinition>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    array.Add(ToolDefinition.DeserializeToolDefinition(item, options));
                }
                tools = array;
                continue;
            }
            if (property.NameEquals("tool_resources"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    toolResources = null;
                    continue;
                }
                toolResources = Assistants.ToolResources.DeserializeToolResources(property.Value, options);
                continue;
            }
            if (property.NameEquals("metadata"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                foreach (var property0 in property.Value.EnumerateObject())
                {
                    dictionary.Add(property0.Name, property0.Value.GetString());
                }
                metadata = dictionary;
                continue;
            }
            if (property.NameEquals("temperature"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    temperature = null;
                    continue;
                }
                temperature = property.Value.GetSingle();
                continue;
            }
            if (property.NameEquals("top_p"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    topP = null;
                    continue;
                }
                topP = property.Value.GetSingle();
                continue;
            }
            if (property.NameEquals("stream"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    stream = null;
                    continue;
                }
                stream = property.Value.GetBoolean();
                continue;
            }
            if (property.NameEquals("max_prompt_tokens"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    maxPromptTokens = null;
                    continue;
                }
                maxPromptTokens = property.Value.GetInt32();
                continue;
            }
            if (property.NameEquals("max_completion_tokens"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    maxCompletionTokens = null;
                    continue;
                }
                maxCompletionTokens = property.Value.GetInt32();
                continue;
            }
            if (property.NameEquals("truncation_strategy"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    truncationStrategy = null;
                    continue;
                }
                truncationStrategy = RunTruncationStrategy.DeserializeRunTruncationStrategy(property.Value, options);
                continue;
            }
            if (property.NameEquals("tool_choice"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    toolChoice = null;
                    continue;
                }
                toolChoice = ToolConstraint.DeserializeToolConstraint(property.Value, options);
                continue;
            }
            if (property.NameEquals("parallel_tool_calls"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                parallelToolCalls = property.Value.GetBoolean();
                continue;
            }
            if (property.NameEquals("response_format"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    responseFormat = null;
                    continue;
                }
                responseFormat = AssistantResponseFormat.DeserializeAssistantResponseFormat(property.Value, options);
                continue;
            }
            if (true)
            {
                rawDataDictionary ??= new Dictionary<string, BinaryData>();
                rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
        }
        serializedAdditionalRawData = rawDataDictionary;
        return new InternalCreateThreadAndRunRequest(
            assistantId,
            thread,
            model,
            instructions,
            tools ?? new ChangeTrackingList<ToolDefinition>(),
            toolResources,
            metadata ?? new ChangeTrackingDictionary<string, string>(),
            temperature,
            topP,
            stream,
            maxPromptTokens,
            maxCompletionTokens,
            truncationStrategy,
            toolChoice,
            parallelToolCalls,
            responseFormat,
            serializedAdditionalRawData);
    }

    BinaryData IPersistableModel<InternalCreateThreadAndRunRequest>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateThreadAndRunRequest>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(InternalCreateThreadAndRunRequest)} does not support writing '{options.Format}' format.");
        }
    }

    InternalCreateThreadAndRunRequest IPersistableModel<InternalCreateThreadAndRunRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateThreadAndRunRequest>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeInternalCreateThreadAndRunRequest(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(InternalCreateThreadAndRunRequest)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<InternalCreateThreadAndRunRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static InternalCreateThreadAndRunRequest FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeInternalCreateThreadAndRunRequest(document.RootElement);
    }

    internal virtual BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}