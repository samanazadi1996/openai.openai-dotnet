// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

internal partial class InternalRunStepDeltaStepDetailsToolCallsFunctionObject : InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject
{
    internal InternalRunStepDeltaStepDetailsToolCallsFunctionObject(int index)
    {
        Type = "function";
        Index = index;
    }

    internal InternalRunStepDeltaStepDetailsToolCallsFunctionObject(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, int index, string id, InternalRunStepDeltaStepDetailsToolCallsFunctionObjectFunction function) : base(type, serializedAdditionalRawData)
    {
        Index = index;
        Id = id;
        Function = function;
    }

    internal InternalRunStepDeltaStepDetailsToolCallsFunctionObject()
    {
    }

    public int Index { get; }
    public string Id { get; }
    public InternalRunStepDeltaStepDetailsToolCallsFunctionObjectFunction Function { get; }
}