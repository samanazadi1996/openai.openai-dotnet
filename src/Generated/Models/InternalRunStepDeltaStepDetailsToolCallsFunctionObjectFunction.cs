// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

internal partial class InternalRunStepDeltaStepDetailsToolCallsFunctionObjectFunction
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    internal InternalRunStepDeltaStepDetailsToolCallsFunctionObjectFunction()
    {
    }

    internal InternalRunStepDeltaStepDetailsToolCallsFunctionObjectFunction(string name, string arguments, string output, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Name = name;
        Arguments = arguments;
        Output = output;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    public string Name { get; }
    public string Arguments { get; }
    public string Output { get; }
}