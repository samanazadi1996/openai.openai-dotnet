// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants;

internal readonly partial struct InternalMessageContentImageUrlObjectImageUrlDetail : IEquatable<InternalMessageContentImageUrlObjectImageUrlDetail>
{
    private readonly string _value;

    public InternalMessageContentImageUrlObjectImageUrlDetail(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string AutoValue = "auto";
    private const string LowValue = "low";
    private const string HighValue = "high";

    public static InternalMessageContentImageUrlObjectImageUrlDetail Auto { get; } = new InternalMessageContentImageUrlObjectImageUrlDetail(AutoValue);
    public static InternalMessageContentImageUrlObjectImageUrlDetail Low { get; } = new InternalMessageContentImageUrlObjectImageUrlDetail(LowValue);
    public static InternalMessageContentImageUrlObjectImageUrlDetail High { get; } = new InternalMessageContentImageUrlObjectImageUrlDetail(HighValue);
    public static bool operator ==(InternalMessageContentImageUrlObjectImageUrlDetail left, InternalMessageContentImageUrlObjectImageUrlDetail right) => left.Equals(right);
    public static bool operator !=(InternalMessageContentImageUrlObjectImageUrlDetail left, InternalMessageContentImageUrlObjectImageUrlDetail right) => !left.Equals(right);
    public static implicit operator InternalMessageContentImageUrlObjectImageUrlDetail(string value) => new InternalMessageContentImageUrlObjectImageUrlDetail(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalMessageContentImageUrlObjectImageUrlDetail other && Equals(other);
    public bool Equals(InternalMessageContentImageUrlObjectImageUrlDetail other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}