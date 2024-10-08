// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

internal partial class InternalMessageDeltaContentTextAnnotationsFilePathObject : InternalMessageDeltaTextContentAnnotation
{
    internal InternalMessageDeltaContentTextAnnotationsFilePathObject(int index)
    {
        Type = "file_path";
        Index = index;
    }

    internal InternalMessageDeltaContentTextAnnotationsFilePathObject(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, int index, string text, InternalMessageDeltaContentTextAnnotationsFilePathObjectFilePath filePath, int? startIndex, int? endIndex) : base(type, serializedAdditionalRawData)
    {
        Index = index;
        Text = text;
        FilePath = filePath;
        StartIndex = startIndex;
        EndIndex = endIndex;
    }

    internal InternalMessageDeltaContentTextAnnotationsFilePathObject()
    {
    }

    public int Index { get; }
    public string Text { get; }
    public InternalMessageDeltaContentTextAnnotationsFilePathObjectFilePath FilePath { get; }
    public int? StartIndex { get; }
    public int? EndIndex { get; }
}