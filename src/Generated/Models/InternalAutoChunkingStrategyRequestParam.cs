// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.VectorStores;

internal partial class InternalAutoChunkingStrategyRequestParam : InternalFileChunkingStrategyRequestParam
{
    public InternalAutoChunkingStrategyRequestParam()
    {
        Type = "auto";
    }

    internal InternalAutoChunkingStrategyRequestParam(string type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
    {
    }
}