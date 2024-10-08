// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.LegacyCompletions;

internal partial class InternalCreateCompletionResponseChoiceLogprobs
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    internal InternalCreateCompletionResponseChoiceLogprobs()
    {
        TextOffset = new ChangeTrackingList<int>();
        TokenLogprobs = new ChangeTrackingList<float>();
        Tokens = new ChangeTrackingList<string>();
        TopLogprobs = new ChangeTrackingList<IDictionary<string, float>>();
    }

    internal InternalCreateCompletionResponseChoiceLogprobs(IReadOnlyList<int> textOffset, IReadOnlyList<float> tokenLogprobs, IReadOnlyList<string> tokens, IReadOnlyList<IDictionary<string, float>> topLogprobs, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        TextOffset = textOffset;
        TokenLogprobs = tokenLogprobs;
        Tokens = tokens;
        TopLogprobs = topLogprobs;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    public IReadOnlyList<int> TextOffset { get; }
    public IReadOnlyList<float> TokenLogprobs { get; }
    public IReadOnlyList<string> Tokens { get; }
    public IReadOnlyList<IDictionary<string, float>> TopLogprobs { get; }
}