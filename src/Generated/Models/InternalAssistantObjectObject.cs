// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants;

internal readonly partial struct InternalAssistantObjectObject : IEquatable<InternalAssistantObjectObject>
{
    private readonly string _value;

    public InternalAssistantObjectObject(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string AssistantValue = "assistant";

    public static InternalAssistantObjectObject Assistant { get; } = new InternalAssistantObjectObject(AssistantValue);
    public static bool operator ==(InternalAssistantObjectObject left, InternalAssistantObjectObject right) => left.Equals(right);
    public static bool operator !=(InternalAssistantObjectObject left, InternalAssistantObjectObject right) => !left.Equals(right);
    public static implicit operator InternalAssistantObjectObject(string value) => new InternalAssistantObjectObject(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalAssistantObjectObject other && Equals(other);
    public bool Equals(InternalAssistantObjectObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}