// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants;

public partial class ThreadRun : IJsonModel<ThreadRun>
{
    void IJsonModel<ThreadRun>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<ThreadRun>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(ThreadRun)} does not support writing '{format}' format.");
        }

        writer.WriteStartObject();
        if (SerializedAdditionalRawData?.ContainsKey("id") != true)
        {
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
        }
        if (SerializedAdditionalRawData?.ContainsKey("object") != true)
        {
            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(Object.ToString());
        }
        if (SerializedAdditionalRawData?.ContainsKey("created_at") != true)
        {
            writer.WritePropertyName("created_at"u8);
            writer.WriteNumberValue(CreatedAt, "U");
        }
        if (SerializedAdditionalRawData?.ContainsKey("thread_id") != true)
        {
            writer.WritePropertyName("thread_id"u8);
            writer.WriteStringValue(ThreadId);
        }
        if (SerializedAdditionalRawData?.ContainsKey("assistant_id") != true)
        {
            writer.WritePropertyName("assistant_id"u8);
            writer.WriteStringValue(AssistantId);
        }
        if (SerializedAdditionalRawData?.ContainsKey("status") != true)
        {
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
        }
        if (SerializedAdditionalRawData?.ContainsKey("required_action") != true)
        {
            if (_internalRequiredAction != null)
            {
                writer.WritePropertyName("required_action"u8);
                writer.WriteObjectValue<InternalRunRequiredAction>(_internalRequiredAction, options);
            }
            else
            {
                writer.WriteNull("required_action");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("last_error") != true)
        {
            if (LastError != null)
            {
                writer.WritePropertyName("last_error"u8);
                writer.WriteObjectValue(LastError, options);
            }
            else
            {
                writer.WriteNull("last_error");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("expires_at") != true)
        {
            if (ExpiresAt != null)
            {
                writer.WritePropertyName("expires_at"u8);
                writer.WriteNumberValue(ExpiresAt.Value, "U");
            }
            else
            {
                writer.WriteNull("expires_at");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("started_at") != true)
        {
            if (StartedAt != null)
            {
                writer.WritePropertyName("started_at"u8);
                writer.WriteNumberValue(StartedAt.Value, "U");
            }
            else
            {
                writer.WriteNull("started_at");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("cancelled_at") != true)
        {
            if (CancelledAt != null)
            {
                writer.WritePropertyName("cancelled_at"u8);
                writer.WriteNumberValue(CancelledAt.Value, "U");
            }
            else
            {
                writer.WriteNull("cancelled_at");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("failed_at") != true)
        {
            if (FailedAt != null)
            {
                writer.WritePropertyName("failed_at"u8);
                writer.WriteNumberValue(FailedAt.Value, "U");
            }
            else
            {
                writer.WriteNull("failed_at");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("completed_at") != true)
        {
            if (CompletedAt != null)
            {
                writer.WritePropertyName("completed_at"u8);
                writer.WriteNumberValue(CompletedAt.Value, "U");
            }
            else
            {
                writer.WriteNull("completed_at");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("incomplete_details") != true)
        {
            if (IncompleteDetails != null)
            {
                writer.WritePropertyName("incomplete_details"u8);
                writer.WriteObjectValue(IncompleteDetails, options);
            }
            else
            {
                writer.WriteNull("incomplete_details");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("model") != true)
        {
            writer.WritePropertyName("model"u8);
            writer.WriteStringValue(Model);
        }
        if (SerializedAdditionalRawData?.ContainsKey("instructions") != true)
        {
            writer.WritePropertyName("instructions"u8);
            writer.WriteStringValue(Instructions);
        }
        if (SerializedAdditionalRawData?.ContainsKey("tools") != true)
        {
            writer.WritePropertyName("tools"u8);
            writer.WriteStartArray();
            foreach (var item in Tools)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
        }
        if (SerializedAdditionalRawData?.ContainsKey("metadata") != true)
        {
            if (Metadata != null && Optional.IsCollectionDefined(Metadata))
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
        if (SerializedAdditionalRawData?.ContainsKey("usage") != true)
        {
            if (Usage != null)
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteObjectValue(Usage, options);
            }
            else
            {
                writer.WriteNull("usage");
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
        if (SerializedAdditionalRawData?.ContainsKey("top_p") != true && Optional.IsDefined(NucleusSamplingFactor))
        {
            if (NucleusSamplingFactor != null)
            {
                writer.WritePropertyName("top_p"u8);
                writer.WriteNumberValue(NucleusSamplingFactor.Value);
            }
            else
            {
                writer.WriteNull("top_p");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("max_prompt_tokens") != true)
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
        if (SerializedAdditionalRawData?.ContainsKey("max_completion_tokens") != true)
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
        if (SerializedAdditionalRawData?.ContainsKey("truncation_strategy") != true)
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
        if (SerializedAdditionalRawData?.ContainsKey("tool_choice") != true)
        {
            if (ToolConstraint != null)
            {
                writer.WritePropertyName("tool_choice"u8);
                writer.WriteObjectValue<ToolConstraint>(ToolConstraint, options);
            }
            else
            {
                writer.WriteNull("tool_choice");
            }
        }
        if (SerializedAdditionalRawData?.ContainsKey("parallel_tool_calls") != true)
        {
            writer.WritePropertyName("parallel_tool_calls"u8);
            writer.WriteBooleanValue(ParallelToolCallsEnabled.Value);
        }
        if (SerializedAdditionalRawData?.ContainsKey("response_format") != true)
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

    ThreadRun IJsonModel<ThreadRun>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<ThreadRun>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(ThreadRun)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeThreadRun(document.RootElement, options);
    }

    internal static ThreadRun DeserializeThreadRun(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        string id = default;
        InternalRunObjectObject @object = default;
        DateTimeOffset createdAt = default;
        string threadId = default;
        string assistantId = default;
        RunStatus status = default;
        InternalRunRequiredAction requiredAction = default;
        RunError lastError = default;
        DateTimeOffset? expiresAt = default;
        DateTimeOffset? startedAt = default;
        DateTimeOffset? cancelledAt = default;
        DateTimeOffset? failedAt = default;
        DateTimeOffset? completedAt = default;
        RunIncompleteDetails incompleteDetails = default;
        string model = default;
        string instructions = default;
        IReadOnlyList<ToolDefinition> tools = default;
        IReadOnlyDictionary<string, string> metadata = default;
        RunTokenUsage usage = default;
        float? temperature = default;
        float? topP = default;
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
            if (property.NameEquals("id"u8))
            {
                id = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("object"u8))
            {
                @object = new InternalRunObjectObject(property.Value.GetString());
                continue;
            }
            if (property.NameEquals("created_at"u8))
            {
                createdAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                continue;
            }
            if (property.NameEquals("thread_id"u8))
            {
                threadId = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("assistant_id"u8))
            {
                assistantId = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("status"u8))
            {
                status = new RunStatus(property.Value.GetString());
                continue;
            }
            if (property.NameEquals("required_action"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    requiredAction = null;
                    continue;
                }
                requiredAction = InternalRunRequiredAction.DeserializeInternalRunRequiredAction(property.Value, options);
                continue;
            }
            if (property.NameEquals("last_error"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    lastError = null;
                    continue;
                }
                lastError = RunError.DeserializeRunError(property.Value, options);
                continue;
            }
            if (property.NameEquals("expires_at"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    expiresAt = null;
                    continue;
                }
                expiresAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                continue;
            }
            if (property.NameEquals("started_at"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    startedAt = null;
                    continue;
                }
                startedAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                continue;
            }
            if (property.NameEquals("cancelled_at"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    cancelledAt = null;
                    continue;
                }
                cancelledAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                continue;
            }
            if (property.NameEquals("failed_at"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    failedAt = null;
                    continue;
                }
                failedAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                continue;
            }
            if (property.NameEquals("completed_at"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    completedAt = null;
                    continue;
                }
                completedAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                continue;
            }
            if (property.NameEquals("incomplete_details"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    incompleteDetails = null;
                    continue;
                }
                incompleteDetails = RunIncompleteDetails.DeserializeRunIncompleteDetails(property.Value, options);
                continue;
            }
            if (property.NameEquals("model"u8))
            {
                model = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("instructions"u8))
            {
                instructions = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("tools"u8))
            {
                List<ToolDefinition> array = new List<ToolDefinition>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    array.Add(ToolDefinition.DeserializeToolDefinition(item, options));
                }
                tools = array;
                continue;
            }
            if (property.NameEquals("metadata"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    metadata = new ChangeTrackingDictionary<string, string>();
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
            if (property.NameEquals("usage"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    usage = null;
                    continue;
                }
                usage = RunTokenUsage.DeserializeRunTokenUsage(property.Value, options);
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
                toolChoice = Assistants.ToolConstraint.DeserializeToolConstraint(property.Value, options);
                continue;
            }
            if (property.NameEquals("parallel_tool_calls"u8))
            {
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
        return new ThreadRun(
            id,
            @object,
            createdAt,
            threadId,
            assistantId,
            status,
            requiredAction,
            lastError,
            expiresAt,
            startedAt,
            cancelledAt,
            failedAt,
            completedAt,
            incompleteDetails,
            model,
            instructions,
            tools,
            metadata,
            usage,
            temperature,
            topP,
            maxPromptTokens,
            maxCompletionTokens,
            truncationStrategy,
            toolChoice,
            parallelToolCalls,
            responseFormat,
            serializedAdditionalRawData);
    }

    BinaryData IPersistableModel<ThreadRun>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<ThreadRun>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(ThreadRun)} does not support writing '{options.Format}' format.");
        }
    }

    ThreadRun IPersistableModel<ThreadRun>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<ThreadRun>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeThreadRun(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(ThreadRun)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<ThreadRun>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static ThreadRun FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeThreadRun(document.RootElement);
    }

    internal virtual BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}