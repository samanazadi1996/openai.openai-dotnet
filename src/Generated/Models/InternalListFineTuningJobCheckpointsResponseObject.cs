// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.FineTuning;

internal readonly partial struct InternalListFineTuningJobCheckpointsResponseObject : IEquatable<InternalListFineTuningJobCheckpointsResponseObject>
{
    private readonly string _value;

    public InternalListFineTuningJobCheckpointsResponseObject(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string ListValue = "list";

    public static InternalListFineTuningJobCheckpointsResponseObject List { get; } = new InternalListFineTuningJobCheckpointsResponseObject(ListValue);
    public static bool operator ==(InternalListFineTuningJobCheckpointsResponseObject left, InternalListFineTuningJobCheckpointsResponseObject right) => left.Equals(right);
    public static bool operator !=(InternalListFineTuningJobCheckpointsResponseObject left, InternalListFineTuningJobCheckpointsResponseObject right) => !left.Equals(right);
    public static implicit operator InternalListFineTuningJobCheckpointsResponseObject(string value) => new InternalListFineTuningJobCheckpointsResponseObject(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalListFineTuningJobCheckpointsResponseObject other && Equals(other);
    public bool Equals(InternalListFineTuningJobCheckpointsResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}