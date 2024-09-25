// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants;

internal partial class InternalCreateThreadRequestToolResourcesFileSearchBase : IJsonModel<InternalCreateThreadRequestToolResourcesFileSearchBase>
{
    void IJsonModel<InternalCreateThreadRequestToolResourcesFileSearchBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateThreadRequestToolResourcesFileSearchBase>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalCreateThreadRequestToolResourcesFileSearchBase)} does not support writing '{format}' format.");
        }

        writer.WriteStartObject();
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

    InternalCreateThreadRequestToolResourcesFileSearchBase IJsonModel<InternalCreateThreadRequestToolResourcesFileSearchBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateThreadRequestToolResourcesFileSearchBase>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(InternalCreateThreadRequestToolResourcesFileSearchBase)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeInternalCreateThreadRequestToolResourcesFileSearchBase(document.RootElement, options);
    }

    internal static InternalCreateThreadRequestToolResourcesFileSearchBase DeserializeInternalCreateThreadRequestToolResourcesFileSearchBase(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        IDictionary<string, BinaryData> serializedAdditionalRawData = default;
        Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
        foreach (var property in element.EnumerateObject())
        {
            if (true)
            {
                rawDataDictionary ??= new Dictionary<string, BinaryData>();
                rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
        }
        serializedAdditionalRawData = rawDataDictionary;
        return new InternalCreateThreadRequestToolResourcesFileSearchBase(serializedAdditionalRawData);
    }

    BinaryData IPersistableModel<InternalCreateThreadRequestToolResourcesFileSearchBase>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateThreadRequestToolResourcesFileSearchBase>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(InternalCreateThreadRequestToolResourcesFileSearchBase)} does not support writing '{options.Format}' format.");
        }
    }

    InternalCreateThreadRequestToolResourcesFileSearchBase IPersistableModel<InternalCreateThreadRequestToolResourcesFileSearchBase>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<InternalCreateThreadRequestToolResourcesFileSearchBase>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeInternalCreateThreadRequestToolResourcesFileSearchBase(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(InternalCreateThreadRequestToolResourcesFileSearchBase)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<InternalCreateThreadRequestToolResourcesFileSearchBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static InternalCreateThreadRequestToolResourcesFileSearchBase FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeInternalCreateThreadRequestToolResourcesFileSearchBase(document.RootElement);
    }

    internal virtual BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}