// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Images;

internal readonly partial struct InternalCreateImageEditRequestSize : IEquatable<InternalCreateImageEditRequestSize>
{
    private readonly string _value;

    public InternalCreateImageEditRequestSize(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string _256x256Value = "256x256";
    private const string _512x512Value = "512x512";
    private const string _1024x1024Value = "1024x1024";

    public static InternalCreateImageEditRequestSize _256x256 { get; } = new InternalCreateImageEditRequestSize(_256x256Value);
    public static InternalCreateImageEditRequestSize _512x512 { get; } = new InternalCreateImageEditRequestSize(_512x512Value);
    public static InternalCreateImageEditRequestSize _1024x1024 { get; } = new InternalCreateImageEditRequestSize(_1024x1024Value);
    public static bool operator ==(InternalCreateImageEditRequestSize left, InternalCreateImageEditRequestSize right) => left.Equals(right);
    public static bool operator !=(InternalCreateImageEditRequestSize left, InternalCreateImageEditRequestSize right) => !left.Equals(right);
    public static implicit operator InternalCreateImageEditRequestSize(string value) => new InternalCreateImageEditRequestSize(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalCreateImageEditRequestSize other && Equals(other);
    public bool Equals(InternalCreateImageEditRequestSize other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}