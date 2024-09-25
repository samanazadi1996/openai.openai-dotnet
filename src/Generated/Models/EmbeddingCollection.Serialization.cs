// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace OpenAI.Embeddings;

public partial class EmbeddingCollection : IJsonModel<EmbeddingCollection>
{
    EmbeddingCollection IJsonModel<EmbeddingCollection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<EmbeddingCollection>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(EmbeddingCollection)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeEmbeddingCollection(document.RootElement, options);
    }

    BinaryData IPersistableModel<EmbeddingCollection>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<EmbeddingCollection>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(EmbeddingCollection)} does not support writing '{options.Format}' format.");
        }
    }

    EmbeddingCollection IPersistableModel<EmbeddingCollection>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<EmbeddingCollection>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeEmbeddingCollection(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(EmbeddingCollection)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<EmbeddingCollection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static EmbeddingCollection FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeEmbeddingCollection(document.RootElement);
    }

    internal virtual BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}