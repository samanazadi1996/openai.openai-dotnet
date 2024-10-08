// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants;

public readonly partial struct RunStepType : IEquatable<RunStepType>
{
    private readonly string _value;

    public RunStepType(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string MessageCreationValue = "message_creation";
    private const string ToolCallsValue = "tool_calls";

    public static RunStepType MessageCreation { get; } = new RunStepType(MessageCreationValue);
    public static RunStepType ToolCalls { get; } = new RunStepType(ToolCallsValue);
    public static bool operator ==(RunStepType left, RunStepType right) => left.Equals(right);
    public static bool operator !=(RunStepType left, RunStepType right) => !left.Equals(right);
    public static implicit operator RunStepType(string value) => new RunStepType(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is RunStepType other && Equals(other);
    public bool Equals(RunStepType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}