// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace OpenAI.Assistants;

[PersistableModelProxy(typeof(UnknownAssistantToolDefinition))]
public partial class ToolDefinition : IJsonModel<ToolDefinition>
{
    ToolDefinition IJsonModel<ToolDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<ToolDefinition>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(ToolDefinition)} does not support reading '{format}' format.");
        }

        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        return DeserializeToolDefinition(document.RootElement, options);
    }

    internal static ToolDefinition DeserializeToolDefinition(JsonElement element, ModelReaderWriterOptions options = null)
    {
        options ??= ModelSerializationExtensions.WireOptions;

        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        if (element.TryGetProperty("type", out JsonElement discriminator))
        {
            switch (discriminator.GetString())
            {
                case "code_interpreter": return CodeInterpreterToolDefinition.DeserializeCodeInterpreterToolDefinition(element, options);
                case "file_search": return FileSearchToolDefinition.DeserializeFileSearchToolDefinition(element, options);
                case "function": return FunctionToolDefinition.DeserializeFunctionToolDefinition(element, options);
            }
        }
        return UnknownAssistantToolDefinition.DeserializeUnknownAssistantToolDefinition(element, options);
    }

    BinaryData IPersistableModel<ToolDefinition>.Write(ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<ToolDefinition>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                return ModelReaderWriter.Write(this, options);
            default:
                throw new FormatException($"The model {nameof(ToolDefinition)} does not support writing '{options.Format}' format.");
        }
    }

    ToolDefinition IPersistableModel<ToolDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
    {
        var format = options.Format == "W" ? ((IPersistableModel<ToolDefinition>)this).GetFormatFromOptions(options) : options.Format;

        switch (format)
        {
            case "J":
                {
                    using JsonDocument document = JsonDocument.Parse(data);
                    return DeserializeToolDefinition(document.RootElement, options);
                }
            default:
                throw new FormatException($"The model {nameof(ToolDefinition)} does not support reading '{options.Format}' format.");
        }
    }

    string IPersistableModel<ToolDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

    internal static ToolDefinition FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeToolDefinition(document.RootElement);
    }

    internal virtual BinaryContent ToBinaryContent()
    {
        return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
    }
}