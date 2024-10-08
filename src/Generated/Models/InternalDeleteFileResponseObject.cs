// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Files;

internal readonly partial struct InternalDeleteFileResponseObject : IEquatable<InternalDeleteFileResponseObject>
{
    private readonly string _value;

    public InternalDeleteFileResponseObject(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string FileValue = "file";

    public static InternalDeleteFileResponseObject File { get; } = new InternalDeleteFileResponseObject(FileValue);
    public static bool operator ==(InternalDeleteFileResponseObject left, InternalDeleteFileResponseObject right) => left.Equals(right);
    public static bool operator !=(InternalDeleteFileResponseObject left, InternalDeleteFileResponseObject right) => !left.Equals(right);
    public static implicit operator InternalDeleteFileResponseObject(string value) => new InternalDeleteFileResponseObject(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalDeleteFileResponseObject other && Equals(other);
    public bool Equals(InternalDeleteFileResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}