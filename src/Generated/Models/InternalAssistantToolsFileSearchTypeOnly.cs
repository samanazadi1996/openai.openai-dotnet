// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

internal partial class InternalAssistantToolsFileSearchTypeOnly
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    public InternalAssistantToolsFileSearchTypeOnly()
    {
    }

    internal InternalAssistantToolsFileSearchTypeOnly(InternalAssistantToolsFileSearchTypeOnlyType type, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Type = type;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    public InternalAssistantToolsFileSearchTypeOnlyType Type { get; } = InternalAssistantToolsFileSearchTypeOnlyType.FileSearch;
}