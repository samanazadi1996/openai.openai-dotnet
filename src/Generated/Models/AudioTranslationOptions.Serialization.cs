// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace OpenAI.Audio;

public partial class AudioTranslationOptions : IJsonModel<AudioTranslationOptions>
{
    void IJsonModel<AudioTranslationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<AudioTranslationOptions>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(AudioTranslationOptions)} does not support writing '{format}' format.");
        }

        writer.WriteStartObject();
        if (SerializedAdditionalRawData?.ContainsKey("file") != true)
        {
            writer.WritePropertyName("file"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(File);
#else
            using (JsonDocument document = JsonDocument.Parse(File))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
        }
        if (SerializedAdditionalRawData?.ContainsKey("model") != true)
        {
            writer.WritePropertyName("model"u8);
            writer.WriteStringValue(Model.ToString());
        }
        if (SerializedAdditionalRawData?.ContainsKey("prompt") != true && Optional.IsDefined(Prompt))
        {
            writer.WritePropertyName("prompt"u8);
            writer.WriteStringValue(Prompt);
        }
        if (SerializedAdditionalRawData?.ContainsKey("response_format") != true && Optional.IsDefined(ResponseFormat))
        {
            writer.WritePropertyName("response_format"u8);
            writer.WriteStringValue(ResponseFormat.Value.ToSerialString());
        }
        if (SerializedAdditionalRawData?.ContainsKey("temperature") != true && Optional.IsDefined(Temperature))
        {
            writer.WritePropertyName("temperature"u8);
            writer.WriteNumberValue(Temperature.Value);
        }
        if (SerializedAdditionalRawData != null)
        {
            foreach (var item in SerializedAdditionalRawData)
            {
                if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                {
                    continue;
                }
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
        }
        writer.WriteEndObject();
    }

    AudioTranslationOptions IJsonModel<AudioTranslationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<AudioTranslationOptions>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(AudioTranslationOptions)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeAudioTranslationOptions(document.RootElement, options);
    }

    internal static AudioTranslationOptions DeserializeAudioTranslationOptions(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        BinaryData file = default;
        InternalCreateTranslationRequestModel model = default;
        string prompt = default;
        AudioTranslationFormat? responseFormat = default;
        float? temperature = default;
        IDictionary<string, BinaryData> serializedAdditionalRawData = default;
        Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("file"u8))
            {
                file = BinaryData.FromString(property.Value.GetRawText());
                continue;
            }
            if (property.NameEquals("model"u8))
            {
                model = new InternalCreateTranslationRequestModel(property.Value.GetString());
                continue;
            }
            if (property.NameEquals("prompt"u8))
            {
                prompt = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("response_format"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                responseFormat = property.Value.GetString().ToAudioTranslationFormat();
                continue;
            }
            if (property.NameEquals("temperature"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                temperature = property.Value.GetSingle();
                continue;
            }
            if (true)
            {
                rawDataDictionary ??= new Dictionary<string, BinaryData>();
                rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
        }
        serializedAdditionalRawData = rawDataDictionary;
        return new AudioTranslationOptions(
            file,
            model,
            prompt,
            responseFormat,
            temperature,
            serializedAdditionalRawData);
    }

    private BinaryData SerializeMultipart(ModelReaderWriterOptions options)
    {
        using MultipartFormDataBinaryContent content = ToMultipartBinaryBody();
        using MemoryStream stream = new MemoryStream();
        content.WriteTo(stream);
        if (stream.Position > int.MaxValue)
        {
            return BinaryData.FromStream(stream);
        }
        else
        {
            return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
        }
    }

    internal virtual MultipartFormDataBinaryContent ToMultipartBinaryBody()
    {
        MultipartFormDataBinaryContent content = new MultipartFormDataBinaryContent();
        content.Add(File, "file", "file");
        content.Add(Model.ToString(), "model");
        if (Optional.IsDefined(Prompt))
        {
            content.Add(Prompt, "prompt");
        }
        if (Optional.IsDefined(ResponseFormat))
        {
            content.Add(ResponseFormat.Value.ToSerialString(), "response_format");
        }
        if (Optional.IsDefined(Temperature))
        {
            content.Add(Temperature.Value, "temperature");
        }
        return content;
    }

    BinaryData IPersistableModel<AudioTranslationOptions>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<AudioTranslationOptions>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            case "MFD":
                return SerializeMultipart(options);
            default:
                throw new FormatException($"The model {nameof(AudioTranslationOptions)} does not support writing '{options.Format}' format.");
        }
    }

    AudioTranslationOptions IPersistableModel<AudioTranslationOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<AudioTranslationOptions>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeAudioTranslationOptions(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(AudioTranslationOptions)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<AudioTranslationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "MFD";

    internal static AudioTranslationOptions FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeAudioTranslationOptions(document.RootElement);
    }

    internal virtual BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}