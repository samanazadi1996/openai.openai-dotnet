// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

public partial class RunStepTokenUsage
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    internal RunStepTokenUsage(int completionTokens, int promptTokens, int totalTokens)
    {
        CompletionTokens = completionTokens;
        PromptTokens = promptTokens;
        TotalTokens = totalTokens;
    }

    internal RunStepTokenUsage(int completionTokens, int promptTokens, int totalTokens, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        CompletionTokens = completionTokens;
        PromptTokens = promptTokens;
        TotalTokens = totalTokens;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal RunStepTokenUsage()
    {
    }

    public int CompletionTokens { get; }
    public int PromptTokens { get; }
    public int TotalTokens { get; }
}