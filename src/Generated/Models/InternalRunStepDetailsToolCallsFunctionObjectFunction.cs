// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

internal partial class InternalRunStepDetailsToolCallsFunctionObjectFunction
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    internal InternalRunStepDetailsToolCallsFunctionObjectFunction(string name, string arguments, string output)
    {
        Argument.AssertNotNull(name, nameof(name));
        Argument.AssertNotNull(arguments, nameof(arguments));

        Name = name;
        Arguments = arguments;
        Output = output;
    }

    internal InternalRunStepDetailsToolCallsFunctionObjectFunction(string name, string arguments, string output, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Name = name;
        Arguments = arguments;
        Output = output;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal InternalRunStepDetailsToolCallsFunctionObjectFunction()
    {
    }

    public string Name { get; }
    public string Arguments { get; }
    public string Output { get; }
}