// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants;

internal readonly partial struct InternalMessageDeltaContentImageUrlObjectImageUrlDetail : IEquatable<InternalMessageDeltaContentImageUrlObjectImageUrlDetail>
{
    private readonly string _value;

    public InternalMessageDeltaContentImageUrlObjectImageUrlDetail(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string AutoValue = "auto";
    private const string LowValue = "low";
    private const string HighValue = "high";

    public static InternalMessageDeltaContentImageUrlObjectImageUrlDetail Auto { get; } = new InternalMessageDeltaContentImageUrlObjectImageUrlDetail(AutoValue);
    public static InternalMessageDeltaContentImageUrlObjectImageUrlDetail Low { get; } = new InternalMessageDeltaContentImageUrlObjectImageUrlDetail(LowValue);
    public static InternalMessageDeltaContentImageUrlObjectImageUrlDetail High { get; } = new InternalMessageDeltaContentImageUrlObjectImageUrlDetail(HighValue);
    public static bool operator ==(InternalMessageDeltaContentImageUrlObjectImageUrlDetail left, InternalMessageDeltaContentImageUrlObjectImageUrlDetail right) => left.Equals(right);
    public static bool operator !=(InternalMessageDeltaContentImageUrlObjectImageUrlDetail left, InternalMessageDeltaContentImageUrlObjectImageUrlDetail right) => !left.Equals(right);
    public static implicit operator InternalMessageDeltaContentImageUrlObjectImageUrlDetail(string value) => new InternalMessageDeltaContentImageUrlObjectImageUrlDetail(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalMessageDeltaContentImageUrlObjectImageUrlDetail other && Equals(other);
    public bool Equals(InternalMessageDeltaContentImageUrlObjectImageUrlDetail other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}