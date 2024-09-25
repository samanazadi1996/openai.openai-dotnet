// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

public abstract partial class AssistantResponseFormat
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    protected AssistantResponseFormat()
    {
    }

    internal AssistantResponseFormat(string type, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Type = type;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal string Type { get; set; }
}