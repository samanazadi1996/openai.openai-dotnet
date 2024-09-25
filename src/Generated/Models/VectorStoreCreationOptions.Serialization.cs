// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.VectorStores;

public partial class VectorStoreCreationOptions : IJsonModel<VectorStoreCreationOptions>
{
    void IJsonModel<VectorStoreCreationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<VectorStoreCreationOptions>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(VectorStoreCreationOptions)} does not support writing '{format}' format.");
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
        if (SerializedAdditionalRawData?.ContainsKey("name") != true && Optional.IsDefined(Name))
        {
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
        }
        if (SerializedAdditionalRawData?.ContainsKey("expires_after") != true && Optional.IsDefined(ExpirationPolicy))
        {
            writer.WritePropertyName("expires_after"u8);
            writer.WriteObjectValue<VectorStoreExpirationPolicy>(ExpirationPolicy, options);
        }
        if (SerializedAdditionalRawData?.ContainsKey("chunking_strategy") != true && Optional.IsDefined(ChunkingStrategy))
        {
            writer.WritePropertyName("chunking_strategy"u8);
            writer.WriteObjectValue<FileChunkingStrategy>(ChunkingStrategy, options);
        }
        if (SerializedAdditionalRawData?.ContainsKey("metadata") != true && Optional.IsCollectionDefined(Metadata))
        {
            if (Metadata != null)
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNull("metadata");
            }
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

    VectorStoreCreationOptions IJsonModel<VectorStoreCreationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<VectorStoreCreationOptions>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(VectorStoreCreationOptions)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeVectorStoreCreationOptions(document.RootElement, options);
    }

    internal static VectorStoreCreationOptions DeserializeVectorStoreCreationOptions(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        IList<string> fileIds = default;
        string name = default;
        VectorStoreExpirationPolicy expiresAfter = default;
        FileChunkingStrategy chunkingStrategy = default;
        IDictionary<string, string> metadata = default;
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
            if (property.NameEquals("name"u8))
            {
                name = property.Value.GetString();
                continue;
            }
            if (property.NameEquals("expires_after"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                expiresAfter = VectorStoreExpirationPolicy.DeserializeVectorStoreExpirationPolicy(property.Value, options);
                continue;
            }
            if (property.NameEquals("chunking_strategy"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                chunkingStrategy = FileChunkingStrategy.DeserializeFileChunkingStrategy(property.Value, options);
                continue;
            }
            if (property.NameEquals("metadata"u8))
            {
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    continue;
                }
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                foreach (var property0 in property.Value.EnumerateObject())
                {
                    dictionary.Add(property0.Name, property0.Value.GetString());
                }
                metadata = dictionary;
                continue;
            }
            if (true)
            {
                rawDataDictionary ??= new Dictionary<string, BinaryData>();
                rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
        }
        serializedAdditionalRawData = rawDataDictionary;
        return new VectorStoreCreationOptions(
            fileIds ?? new ChangeTrackingList<string>(),
            name,
            expiresAfter,
            chunkingStrategy,
            metadata ?? new ChangeTrackingDictionary<string, string>(),
            serializedAdditionalRawData);
    }

    BinaryData IPersistableModel<VectorStoreCreationOptions>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<VectorStoreCreationOptions>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(VectorStoreCreationOptions)} does not support writing '{options.Format}' format.");
        }
    }

    VectorStoreCreationOptions IPersistableModel<VectorStoreCreationOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<VectorStoreCreationOptions>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeVectorStoreCreationOptions(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(VectorStoreCreationOptions)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<VectorStoreCreationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static VectorStoreCreationOptions FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeVectorStoreCreationOptions(document.RootElement);
    }

    internal virtual BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}