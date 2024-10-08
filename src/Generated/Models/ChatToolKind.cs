// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Chat;

public readonly partial struct ChatToolKind : IEquatable<ChatToolKind>
{
    private readonly string _value;

    public ChatToolKind(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string FunctionValue = "function";

    public static ChatToolKind Function { get; } = new ChatToolKind(FunctionValue);
    public static bool operator ==(ChatToolKind left, ChatToolKind right) => left.Equals(right);
    public static bool operator !=(ChatToolKind left, ChatToolKind right) => !left.Equals(right);
    public static implicit operator ChatToolKind(string value) => new ChatToolKind(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is ChatToolKind other && Equals(other);
    public bool Equals(ChatToolKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}