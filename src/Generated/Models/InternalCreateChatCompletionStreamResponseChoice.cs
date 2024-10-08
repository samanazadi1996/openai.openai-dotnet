// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat;

internal partial class InternalCreateChatCompletionStreamResponseChoice
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    internal InternalCreateChatCompletionStreamResponseChoice(InternalChatCompletionStreamResponseDelta delta, ChatFinishReason? finishReason, int index)
    {
        Argument.AssertNotNull(delta, nameof(delta));

        Delta = delta;
        FinishReason = finishReason;
        Index = index;
    }

    internal InternalCreateChatCompletionStreamResponseChoice(InternalChatCompletionStreamResponseDelta delta, InternalCreateChatCompletionStreamResponseChoiceLogprobs logprobs, ChatFinishReason? finishReason, int index, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Delta = delta;
        Logprobs = logprobs;
        FinishReason = finishReason;
        Index = index;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal InternalCreateChatCompletionStreamResponseChoice()
    {
    }

    public InternalChatCompletionStreamResponseDelta Delta { get; }
    public InternalCreateChatCompletionStreamResponseChoiceLogprobs Logprobs { get; }
    public int Index { get; }
}