// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.VectorStores;

internal readonly partial struct InternalListFilesInVectorStoreBatchRequestOrder : IEquatable<InternalListFilesInVectorStoreBatchRequestOrder>
{
    private readonly string _value;

    public InternalListFilesInVectorStoreBatchRequestOrder(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string AscValue = "asc";
    private const string DescValue = "desc";

    public static InternalListFilesInVectorStoreBatchRequestOrder Asc { get; } = new InternalListFilesInVectorStoreBatchRequestOrder(AscValue);
    public static InternalListFilesInVectorStoreBatchRequestOrder Desc { get; } = new InternalListFilesInVectorStoreBatchRequestOrder(DescValue);
    public static bool operator ==(InternalListFilesInVectorStoreBatchRequestOrder left, InternalListFilesInVectorStoreBatchRequestOrder right) => left.Equals(right);
    public static bool operator !=(InternalListFilesInVectorStoreBatchRequestOrder left, InternalListFilesInVectorStoreBatchRequestOrder right) => !left.Equals(right);
    public static implicit operator InternalListFilesInVectorStoreBatchRequestOrder(string value) => new InternalListFilesInVectorStoreBatchRequestOrder(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalListFilesInVectorStoreBatchRequestOrder other && Equals(other);
    public bool Equals(InternalListFilesInVectorStoreBatchRequestOrder other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}