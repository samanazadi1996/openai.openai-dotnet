// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Models;

internal readonly partial struct InternalDeleteModelResponseObject : IEquatable<InternalDeleteModelResponseObject>
{
    private readonly string _value;

    public InternalDeleteModelResponseObject(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string ModelValue = "model";

    public static InternalDeleteModelResponseObject Model { get; } = new InternalDeleteModelResponseObject(ModelValue);
    public static bool operator ==(InternalDeleteModelResponseObject left, InternalDeleteModelResponseObject right) => left.Equals(right);
    public static bool operator !=(InternalDeleteModelResponseObject left, InternalDeleteModelResponseObject right) => !left.Equals(right);
    public static implicit operator InternalDeleteModelResponseObject(string value) => new InternalDeleteModelResponseObject(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalDeleteModelResponseObject other && Equals(other);
    public bool Equals(InternalDeleteModelResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}