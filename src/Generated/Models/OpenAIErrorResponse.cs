// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Internal;

internal partial class OpenAIErrorResponse
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    internal OpenAIErrorResponse(OpenAIError error)
    {
        Argument.AssertNotNull(error, nameof(error));

        Error = error;
    }

    internal OpenAIErrorResponse(OpenAIError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Error = error;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal OpenAIErrorResponse()
    {
    }

    public OpenAIError Error { get; }
}