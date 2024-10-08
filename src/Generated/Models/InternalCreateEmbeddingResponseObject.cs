// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Embeddings;

internal readonly partial struct InternalCreateEmbeddingResponseObject : IEquatable<InternalCreateEmbeddingResponseObject>
{
    private readonly string _value;

    public InternalCreateEmbeddingResponseObject(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string ListValue = "list";

    public static InternalCreateEmbeddingResponseObject List { get; } = new InternalCreateEmbeddingResponseObject(ListValue);
    public static bool operator ==(InternalCreateEmbeddingResponseObject left, InternalCreateEmbeddingResponseObject right) => left.Equals(right);
    public static bool operator !=(InternalCreateEmbeddingResponseObject left, InternalCreateEmbeddingResponseObject right) => !left.Equals(right);
    public static implicit operator InternalCreateEmbeddingResponseObject(string value) => new InternalCreateEmbeddingResponseObject(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalCreateEmbeddingResponseObject other && Equals(other);
    public bool Equals(InternalCreateEmbeddingResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}