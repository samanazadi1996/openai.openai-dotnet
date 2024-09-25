// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

public partial class RunError
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    internal RunError(RunErrorCode code, string message)
    {
        Argument.AssertNotNull(message, nameof(message));

        Code = code;
        Message = message;
    }

    internal RunError(RunErrorCode code, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Code = code;
        Message = message;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal RunError()
    {
    }

    public RunErrorCode Code { get; }
    public string Message { get; }
}