// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

internal partial class InternalMessageDeltaContentTextAnnotationsFileCitationObject : InternalMessageDeltaTextContentAnnotation
{
    internal InternalMessageDeltaContentTextAnnotationsFileCitationObject(int index)
    {
        Type = "file_citation";
        Index = index;
    }

    internal InternalMessageDeltaContentTextAnnotationsFileCitationObject(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, int index, string text, InternalMessageDeltaContentTextAnnotationsFileCitationObjectFileCitation fileCitation, int? startIndex, int? endIndex) : base(type, serializedAdditionalRawData)
    {
        Index = index;
        Text = text;
        FileCitation = fileCitation;
        StartIndex = startIndex;
        EndIndex = endIndex;
    }

    internal InternalMessageDeltaContentTextAnnotationsFileCitationObject()
    {
    }

    public int Index { get; }
    public string Text { get; }
    public InternalMessageDeltaContentTextAnnotationsFileCitationObjectFileCitation FileCitation { get; }
    public int? StartIndex { get; }
    public int? EndIndex { get; }
}