// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants;

public partial class CodeInterpreterToolResources : IJsonModel<CodeInterpreterToolResources>
{
    void IJsonModel<CodeInterpreterToolResources>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<CodeInterpreterToolResources>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(CodeInterpreterToolResources)} does not support writing '{format}' format.");
        }

        writer.WriteStartObject();
        if (SerializedAdditionalRawData?.ContainsKey("file_ids") != true && Optional.IsCollectionDefined(FileIds))
        {
            writer.WritePropertyName("file_ids"u8);
            writer.WriteStartArray();
            foreach (var item in FileIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

    CodeInterpreterToolResources IJsonModel<CodeInterpreterToolResources>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<CodeInterpreterToolResources>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(CodeInterpreterToolResources)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeCodeInterpreterToolResources(document.RootElement, options);
    }

    internal static CodeInterpreterToolResources DeserializeCodeInterpreterToolResources(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        IList<string> fileIds = default;
        IDictionary<string, BinaryData> serializedAdditionalRawData = default;
        Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("file_ids"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                List<string> array = new List<string>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    array.Add(item.GetString());
                }
                fileIds = array;
                continue;
            }
            if (true)
            {
                rawDataDictionary ??= new Dictionary<string, BinaryData>();
                rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
        }
        serializedAdditionalRawData = rawDataDictionary;
        return new CodeInterpreterToolResources(fileIds ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
    }

    BinaryData IPersistableModel<CodeInterpreterToolResources>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<CodeInterpreterToolResources>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(CodeInterpreterToolResources)} does not support writing '{options.Format}' format.");
        }
    }

    CodeInterpreterToolResources IPersistableModel<CodeInterpreterToolResources>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<CodeInterpreterToolResources>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeCodeInterpreterToolResources(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(CodeInterpreterToolResources)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<CodeInterpreterToolResources>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static CodeInterpreterToolResources FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeCodeInterpreterToolResources(document.RootElement);
    }

    internal virtual BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}