// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

internal abstract partial class InternalMessageDeltaContent
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    protected InternalMessageDeltaContent()
    {
    }

    internal InternalMessageDeltaContent(string type, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Type = type;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal string Type { get; set; }
}