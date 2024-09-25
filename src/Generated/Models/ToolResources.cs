// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

public partial class ToolResources
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }

    internal ToolResources(CodeInterpreterToolResources codeInterpreter, FileSearchToolResources fileSearch, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        CodeInterpreter = codeInterpreter;
        FileSearch = fileSearch;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }
}