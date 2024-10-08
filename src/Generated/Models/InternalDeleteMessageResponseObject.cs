// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants;

internal readonly partial struct InternalDeleteMessageResponseObject : IEquatable<InternalDeleteMessageResponseObject>
{
    private readonly string _value;

    public InternalDeleteMessageResponseObject(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string ThreadMessageDeletedValue = "thread.message.deleted";

    public static InternalDeleteMessageResponseObject ThreadMessageDeleted { get; } = new InternalDeleteMessageResponseObject(ThreadMessageDeletedValue);
    public static bool operator ==(InternalDeleteMessageResponseObject left, InternalDeleteMessageResponseObject right) => left.Equals(right);
    public static bool operator !=(InternalDeleteMessageResponseObject left, InternalDeleteMessageResponseObject right) => !left.Equals(right);
    public static implicit operator InternalDeleteMessageResponseObject(string value) => new InternalDeleteMessageResponseObject(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalDeleteMessageResponseObject other && Equals(other);
    public bool Equals(InternalDeleteMessageResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}