// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Assistants;

internal partial class InternalSubmitToolOutputsRunRequest
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    public InternalSubmitToolOutputsRunRequest(IEnumerable<ToolOutput> toolOutputs)
    {
        Argument.AssertNotNull(toolOutputs, nameof(toolOutputs));

        ToolOutputs = toolOutputs.ToList();
    }

    internal InternalSubmitToolOutputsRunRequest(IList<ToolOutput> toolOutputs, bool? stream, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        ToolOutputs = toolOutputs;
        Stream = stream;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal InternalSubmitToolOutputsRunRequest()
    {
    }

    public IList<ToolOutput> ToolOutputs { get; }
    public bool? Stream { get; set; }
}