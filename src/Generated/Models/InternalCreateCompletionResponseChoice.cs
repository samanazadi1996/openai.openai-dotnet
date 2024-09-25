// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.LegacyCompletions;

internal partial class InternalCreateCompletionResponseChoice
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    internal InternalCreateCompletionResponseChoice(InternalCreateCompletionResponseChoiceFinishReason finishReason, int index, InternalCreateCompletionResponseChoiceLogprobs logprobs, string text)
    {
        Argument.AssertNotNull(text, nameof(text));

        FinishReason = finishReason;
        Index = index;
        Logprobs = logprobs;
        Text = text;
    }

    internal InternalCreateCompletionResponseChoice(InternalCreateCompletionResponseChoiceFinishReason finishReason, int index, InternalCreateCompletionResponseChoiceLogprobs logprobs, string text, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        FinishReason = finishReason;
        Index = index;
        Logprobs = logprobs;
        Text = text;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal InternalCreateCompletionResponseChoice()
    {
    }

    public InternalCreateCompletionResponseChoiceFinishReason FinishReason { get; }
    public int Index { get; }
    public InternalCreateCompletionResponseChoiceLogprobs Logprobs { get; }
    public string Text { get; }
}