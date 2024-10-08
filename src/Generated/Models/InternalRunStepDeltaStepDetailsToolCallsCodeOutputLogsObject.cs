// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

internal partial class InternalRunStepDeltaStepDetailsToolCallsCodeOutputLogsObject : RunStepUpdateCodeInterpreterOutput
{
    internal InternalRunStepDeltaStepDetailsToolCallsCodeOutputLogsObject(int index)
    {
        Type = "logs";
        Index = index;
    }

    internal InternalRunStepDeltaStepDetailsToolCallsCodeOutputLogsObject(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, int index, string internalLogs) : base(type, serializedAdditionalRawData)
    {
        Index = index;
        InternalLogs = internalLogs;
    }

    internal InternalRunStepDeltaStepDetailsToolCallsCodeOutputLogsObject()
    {
    }

    public int Index { get; }
}