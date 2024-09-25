// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI.Chat;

namespace OpenAI.LegacyCompletions;

internal partial class InternalCreateCompletionResponse
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    internal InternalCreateCompletionResponse(string id, IEnumerable<InternalCreateCompletionResponseChoice> choices, DateTimeOffset created, string model)
    {
        Argument.AssertNotNull(id, nameof(id));
        Argument.AssertNotNull(choices, nameof(choices));
        Argument.AssertNotNull(model, nameof(model));

        Id = id;
        Choices = choices.ToList();
        Created = created;
        Model = model;
    }

    internal InternalCreateCompletionResponse(string id, IReadOnlyList<InternalCreateCompletionResponseChoice> choices, DateTimeOffset created, string model, string systemFingerprint, InternalCreateCompletionResponseObject @object, ChatTokenUsage usage, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Id = id;
        Choices = choices;
        Created = created;
        Model = model;
        SystemFingerprint = systemFingerprint;
        Object = @object;
        Usage = usage;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal InternalCreateCompletionResponse()
    {
    }

    public string Id { get; }
    public IReadOnlyList<InternalCreateCompletionResponseChoice> Choices { get; }
    public DateTimeOffset Created { get; }
    public string Model { get; }
    public string SystemFingerprint { get; }
    public InternalCreateCompletionResponseObject Object { get; } = InternalCreateCompletionResponseObject.TextCompletion;

    public ChatTokenUsage Usage { get; }
}