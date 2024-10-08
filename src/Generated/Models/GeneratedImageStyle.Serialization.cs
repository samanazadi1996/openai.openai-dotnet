// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Images;

internal static partial class GeneratedImageStyleExtensions
{
    public static string ToSerialString(this GeneratedImageStyle value) => value switch
    {
        GeneratedImageStyle.Vivid => "vivid",
        GeneratedImageStyle.Natural => "natural",
        _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown GeneratedImageStyle value.")
    };

    public static GeneratedImageStyle ToGeneratedImageStyle(this string value)
    {
        if (StringComparer.OrdinalIgnoreCase.Equals(value, "vivid")) return GeneratedImageStyle.Vivid;
        if (StringComparer.OrdinalIgnoreCase.Equals(value, "natural")) return GeneratedImageStyle.Natural;
        throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown GeneratedImageStyle value.");
    }
}