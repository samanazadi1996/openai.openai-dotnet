// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Files;

public readonly partial struct OpenAIFilePurpose : IEquatable<OpenAIFilePurpose>
{
    private readonly string _value;

    public OpenAIFilePurpose(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    private const string AssistantsValue = "assistants";
    private const string AssistantsOutputValue = "assistants_output";
    private const string BatchValue = "batch";
    private const string BatchOutputValue = "batch_output";
    private const string FineTuneValue = "fine-tune";
    private const string FineTuneResultsValue = "fine-tune-results";
    private const string VisionValue = "vision";

    public static OpenAIFilePurpose Assistants { get; } = new OpenAIFilePurpose(AssistantsValue);
    public static OpenAIFilePurpose AssistantsOutput { get; } = new OpenAIFilePurpose(AssistantsOutputValue);
    public static OpenAIFilePurpose Batch { get; } = new OpenAIFilePurpose(BatchValue);
    public static OpenAIFilePurpose BatchOutput { get; } = new OpenAIFilePurpose(BatchOutputValue);
    public static OpenAIFilePurpose FineTune { get; } = new OpenAIFilePurpose(FineTuneValue);
    public static OpenAIFilePurpose FineTuneResults { get; } = new OpenAIFilePurpose(FineTuneResultsValue);
    public static OpenAIFilePurpose Vision { get; } = new OpenAIFilePurpose(VisionValue);
    public static bool operator ==(OpenAIFilePurpose left, OpenAIFilePurpose right) => left.Equals(right);
    public static bool operator !=(OpenAIFilePurpose left, OpenAIFilePurpose right) => !left.Equals(right);
    public static implicit operator OpenAIFilePurpose(string value) => new OpenAIFilePurpose(value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => obj is OpenAIFilePurpose other && Equals(other);
    public bool Equals(OpenAIFilePurpose other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
    public override string ToString() => _value;
}