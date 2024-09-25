// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

internal partial class InternalRunStepFunctionToolCallDetails : RunStepToolCall
{
    internal InternalRunStepFunctionToolCallDetails(string id, InternalRunStepDetailsToolCallsFunctionObjectFunction internalFunction)
    {
        Argument.AssertNotNull(id, nameof(id));
        Argument.AssertNotNull(internalFunction, nameof(internalFunction));

        Type = "function";
        Id = id;
        _internalFunction = internalFunction;
    }

    internal InternalRunStepFunctionToolCallDetails(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, string id, InternalRunStepDetailsToolCallsFunctionObjectFunction internalFunction) : base(type, serializedAdditionalRawData)
    {
        Id = id;
        _internalFunction = internalFunction;
    }

    internal InternalRunStepFunctionToolCallDetails()
    {
    }

    public string Id { get; }
}