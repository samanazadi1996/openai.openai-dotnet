// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Chat;

internal readonly partial struct InternalChatCompletionStreamResponseDeltaRole : IEquatable<InternalChatCompletionStreamResponseDeltaRole>
{
    private readonly string _value;

    public InternalChatCompletionStreamResponseDeltaRole(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string SystemValue = "system";
    private const string UserValue = "user";
    private const string AssistantValue = "assistant";
    private const string ToolValue = "tool";

    public static InternalChatCompletionStreamResponseDeltaRole System { get; } = new InternalChatCompletionStreamResponseDeltaRole(SystemValue);
    public static InternalChatCompletionStreamResponseDeltaRole User { get; } = new InternalChatCompletionStreamResponseDeltaRole(UserValue);
    public static InternalChatCompletionStreamResponseDeltaRole Assistant { get; } = new InternalChatCompletionStreamResponseDeltaRole(AssistantValue);
    public static InternalChatCompletionStreamResponseDeltaRole Tool { get; } = new InternalChatCompletionStreamResponseDeltaRole(ToolValue);
    public static bool operator ==(InternalChatCompletionStreamResponseDeltaRole left, InternalChatCompletionStreamResponseDeltaRole right) => left.Equals(right);
    public static bool operator !=(InternalChatCompletionStreamResponseDeltaRole left, InternalChatCompletionStreamResponseDeltaRole right) => !left.Equals(right);
    public static implicit operator InternalChatCompletionStreamResponseDeltaRole(string value) => new InternalChatCompletionStreamResponseDeltaRole(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalChatCompletionStreamResponseDeltaRole other && Equals(other);
    public bool Equals(InternalChatCompletionStreamResponseDeltaRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}