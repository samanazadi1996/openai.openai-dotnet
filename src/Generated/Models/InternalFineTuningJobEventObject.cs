// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.FineTuning;

internal readonly partial struct InternalFineTuningJobEventObject : IEquatable<InternalFineTuningJobEventObject>
{
    private readonly string _value;

    public InternalFineTuningJobEventObject(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string FineTuningJobEventValue = "fine_tuning.job.event";

    public static InternalFineTuningJobEventObject FineTuningJobEvent { get; } = new InternalFineTuningJobEventObject(FineTuningJobEventValue);
    public static bool operator ==(InternalFineTuningJobEventObject left, InternalFineTuningJobEventObject right) => left.Equals(right);
    public static bool operator !=(InternalFineTuningJobEventObject left, InternalFineTuningJobEventObject right) => !left.Equals(right);
    public static implicit operator InternalFineTuningJobEventObject(string value) => new InternalFineTuningJobEventObject(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalFineTuningJobEventObject other && Equals(other);
    public bool Equals(InternalFineTuningJobEventObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}