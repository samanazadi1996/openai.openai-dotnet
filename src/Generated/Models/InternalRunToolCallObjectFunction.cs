// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

internal partial class InternalRunToolCallObjectFunction
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    internal InternalRunToolCallObjectFunction(string name, string arguments)
    {
        Argument.AssertNotNull(name, nameof(name));
        Argument.AssertNotNull(arguments, nameof(arguments));

        Name = name;
        Arguments = arguments;
    }

    internal InternalRunToolCallObjectFunction(string name, string arguments, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Name = name;
        Arguments = arguments;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal InternalRunToolCallObjectFunction()
    {
    }

    public string Name { get; }
    public string Arguments { get; }
}