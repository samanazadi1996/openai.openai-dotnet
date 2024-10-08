// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.VectorStores;

internal partial class InternalCreateVectorStoreFileRequest
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    public InternalCreateVectorStoreFileRequest(string fileId)
    {
        Argument.AssertNotNull(fileId, nameof(fileId));

        FileId = fileId;
    }

    internal InternalCreateVectorStoreFileRequest(string fileId, FileChunkingStrategy chunkingStrategy, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        FileId = fileId;
        ChunkingStrategy = chunkingStrategy;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal InternalCreateVectorStoreFileRequest()
    {
    }

    public string FileId { get; }
}