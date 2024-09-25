// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Files;

internal readonly partial struct InternalUploadStatus : IEquatable<InternalUploadStatus>
{
    private readonly string _value;

    public InternalUploadStatus(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string PendingValue = "pending";
    private const string CompletedValue = "completed";
    private const string CancelledValue = "cancelled";
    private const string ExpiredValue = "expired";

    public static InternalUploadStatus Pending { get; } = new InternalUploadStatus(PendingValue);
    public static InternalUploadStatus Completed { get; } = new InternalUploadStatus(CompletedValue);
    public static InternalUploadStatus Cancelled { get; } = new InternalUploadStatus(CancelledValue);
    public static InternalUploadStatus Expired { get; } = new InternalUploadStatus(ExpiredValue);
    public static bool operator ==(InternalUploadStatus left, InternalUploadStatus right) => left.Equals(right);
    public static bool operator !=(InternalUploadStatus left, InternalUploadStatus right) => !left.Equals(right);
    public static implicit operator InternalUploadStatus(string value) => new InternalUploadStatus(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is InternalUploadStatus other && Equals(other);
    public bool Equals(InternalUploadStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}