// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Batch;

internal readonly partial struct InternalBatchStatus : IEquatable<InternalBatchStatus>
{
    private readonly string _value;

    public InternalBatchStatus(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string ValidatingValue = "validating";
    private const string FailedValue = "failed";
    private const string InProgressValue = "in_progress";
    private const string FinalizingValue = "finalizing";
    private const string CompletedValue = "completed";
    private const string ExpiredValue = "expired";
    private const string CancellingValue = "cancelling";
    private const string CancelledValue = "cancelled";

    public static InternalBatchStatus Validating { get; } = new InternalBatchStatus(ValidatingValue);
    public static InternalBatchStatus Failed { get; } = new InternalBatchStatus(FailedValue);
    public static InternalBatchStatus InProgress { get; } = new InternalBatchStatus(InProgressValue);
    public static InternalBatchStatus Finalizing { get; } = new InternalBatchStatus(FinalizingValue);
    public static InternalBatchStatus Completed { get; } = new InternalBatchStatus(CompletedValue);
    public static InternalBatchStatus Expired { get; } = new InternalBatchStatus(ExpiredValue);
    public static InternalBatchStatus Cancelling { get; } = new InternalBatchStatus(CancellingValue);
    public static InternalBatchStatus Cancelled { get; } = new InternalBatchStatus(CancelledValue);
    public static bool operator ==(InternalBatchStatus left, InternalBatchStatus right) => left.Equals(right);
    public static bool operator !=(InternalBatchStatus left, InternalBatchStatus right) => !left.Equals(right);
    public static implicit operator InternalBatchStatus(string value) => new InternalBatchStatus(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalBatchStatus other && Equals(other);
    public bool Equals(InternalBatchStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}