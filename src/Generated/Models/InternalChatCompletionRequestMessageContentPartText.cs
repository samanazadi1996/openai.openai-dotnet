// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat;

internal partial class InternalChatCompletionRequestMessageContentPartText
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    public InternalChatCompletionRequestMessageContentPartText(string text)
    {
        Argument.AssertNotNull(text, nameof(text));

        Text = text;
    }

    internal InternalChatCompletionRequestMessageContentPartText(InternalChatCompletionRequestMessageContentPartTextType type, string text, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Type = type;
        Text = text;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal InternalChatCompletionRequestMessageContentPartText()
    {
    }

    public InternalChatCompletionRequestMessageContentPartTextType Type { get; } = InternalChatCompletionRequestMessageContentPartTextType.Text;

    public string Text { get; }
}