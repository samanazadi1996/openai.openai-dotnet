// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat;

public partial class ChatTokenTopLogProbabilityDetails
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    internal ChatTokenTopLogProbabilityDetails(string token, float logProbability, ReadOnlyMemory<byte>? utf8Bytes)
    {
        Argument.AssertNotNull(token, nameof(token));

        Token = token;
        LogProbability = logProbability;
        Utf8Bytes = utf8Bytes;
    }

    internal ChatTokenTopLogProbabilityDetails(string token, float logProbability, ReadOnlyMemory<byte>? utf8Bytes, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Token = token;
        LogProbability = logProbability;
        Utf8Bytes = utf8Bytes;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal ChatTokenTopLogProbabilityDetails()
    {
    }

    public string Token { get; }
}