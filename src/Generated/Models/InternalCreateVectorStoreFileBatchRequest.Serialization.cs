// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.VectorStores;

internal partial class InternalCreateVectorStoreFileBatchRequest : IJsonModel<InternalCreateVectorStoreFileBatchRequest>
{
    void IJsonModel<InternalCreateVectorStoreFileBatchRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateVectorStoreFileBatchRequest>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalCreateVectorStoreFileBatchRequest)} does not support writing '{format}' format.");
        }

        writer.WriteStartObject();
        if (SerializedAdditionalRawData?.ContainsKey("file_ids") != true)
        {
            writer.WritePropertyName("file_ids"u8);
            writer.WriteStartArray();
            foreach (var item in FileIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
        }
        if (SerializedAdditionalRawData?.ContainsKey("chunking_strategy") != true && Optional.IsDefined(ChunkingStrategy))
        {
            writer.WritePropertyName("chunking_strategy"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ChunkingStrategy);
#else
            using (JsonDocument document = JsonDocument.Parse(ChunkingStrategy))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
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

    InternalCreateVectorStoreFileBatchRequest IJsonModel<InternalCreateVectorStoreFileBatchRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateVectorStoreFileBatchRequest>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalCreateVectorStoreFileBatchRequest)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeInternalCreateVectorStoreFileBatchRequest(document.RootElement, options);
    }

    internal static InternalCreateVectorStoreFileBatchRequest DeserializeInternalCreateVectorStoreFileBatchRequest(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        IList<string> fileIds = default;
        BinaryData chunkingStrategy = default;
        IDictionary<string, BinaryData> serializedAdditionalRawData = default;
        Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("file_ids"u8))
            {
                List<string> array = new List<string>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    array.Add(item.GetString());
                }
                fileIds = array;
                continue;
            }
            if (property.NameEquals("chunking_strategy"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                chunkingStrategy = BinaryData.FromString(property.Value.GetRawText());
                continue;
            }
            if (true)
            {
                rawDataDictionary ??= new Dictionary<string, BinaryData>();
                rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
        }
        serializedAdditionalRawData = rawDataDictionary;
        return new InternalCreateVectorStoreFileBatchRequest(fileIds, chunkingStrategy, serializedAdditionalRawData);
    }

    BinaryData IPersistableModel<InternalCreateVectorStoreFileBatchRequest>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateVectorStoreFileBatchRequest>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(InternalCreateVectorStoreFileBatchRequest)} does not support writing '{options.Format}' format.");
        }
    }

    InternalCreateVectorStoreFileBatchRequest IPersistableModel<InternalCreateVectorStoreFileBatchRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateVectorStoreFileBatchRequest>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeInternalCreateVectorStoreFileBatchRequest(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(InternalCreateVectorStoreFileBatchRequest)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<InternalCreateVectorStoreFileBatchRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static InternalCreateVectorStoreFileBatchRequest FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeInternalCreateVectorStoreFileBatchRequest(document.RootElement);
    }

    internal virtual BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}