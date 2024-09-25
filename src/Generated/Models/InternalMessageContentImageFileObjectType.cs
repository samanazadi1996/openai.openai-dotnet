// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants;

internal readonly partial struct InternalMessageContentImageFileObjectType : IEquatable<InternalMessageContentImageFileObjectType>
{
    private readonly string _value;

    public InternalMessageContentImageFileObjectType(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string ImageFileValue = "image_file";

    public static InternalMessageContentImageFileObjectType ImageFile { get; } = new InternalMessageContentImageFileObjectType(ImageFileValue);
    public static bool operator ==(InternalMessageContentImageFileObjectType left, InternalMessageContentImageFileObjectType right) => left.Equals(right);
    public static bool operator !=(InternalMessageContentImageFileObjectType left, InternalMessageContentImageFileObjectType right) => !left.Equals(right);
    public static implicit operator InternalMessageContentImageFileObjectType(string value) => new InternalMessageContentImageFileObjectType(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalMessageContentImageFileObjectType other && Equals(other);
    public bool Equals(InternalMessageContentImageFileObjectType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}