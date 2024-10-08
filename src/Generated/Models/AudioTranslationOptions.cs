// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Audio;

public partial class AudioTranslationOptions
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }

    internal AudioTranslationOptions(BinaryData file, InternalCreateTranslationRequestModel model, string prompt, AudioTranslationFormat? responseFormat, float? temperature, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        File = file;
        Model = model;
        Prompt = prompt;
        ResponseFormat = responseFormat;
        Temperature = temperature;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }
    public string Prompt { get; set; }
    public AudioTranslationFormat? ResponseFormat { get; set; }
    public float? Temperature { get; set; }
}