// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.FineTuning;

internal readonly partial struct FineTuningJobHyperparametersNEpochsChoiceEnum : IEquatable<FineTuningJobHyperparametersNEpochsChoiceEnum>
{
    private readonly string _value;

    public FineTuningJobHyperparametersNEpochsChoiceEnum(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string AutoValue = "auto";

    public static FineTuningJobHyperparametersNEpochsChoiceEnum Auto { get; } = new FineTuningJobHyperparametersNEpochsChoiceEnum(AutoValue);
    public static bool operator ==(FineTuningJobHyperparametersNEpochsChoiceEnum left, FineTuningJobHyperparametersNEpochsChoiceEnum right) => left.Equals(right);
    public static bool operator !=(FineTuningJobHyperparametersNEpochsChoiceEnum left, FineTuningJobHyperparametersNEpochsChoiceEnum right) => !left.Equals(right);
    public static implicit operator FineTuningJobHyperparametersNEpochsChoiceEnum(string value) => new FineTuningJobHyperparametersNEpochsChoiceEnum(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is FineTuningJobHyperparametersNEpochsChoiceEnum other && Equals(other);
    public bool Equals(FineTuningJobHyperparametersNEpochsChoiceEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}