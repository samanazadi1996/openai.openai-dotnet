// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.VectorStores;

public partial class VectorStoreFileAssociation
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    internal VectorStoreFileAssociation(string fileId, int size, DateTimeOffset createdAt, string vectorStoreId, VectorStoreFileAssociationStatus status, VectorStoreFileAssociationError lastError)
    {
        Argument.AssertNotNull(fileId, nameof(fileId));
        Argument.AssertNotNull(vectorStoreId, nameof(vectorStoreId));

        FileId = fileId;
        Size = size;
        CreatedAt = createdAt;
        VectorStoreId = vectorStoreId;
        Status = status;
        LastError = lastError;
    }

    internal VectorStoreFileAssociation(string fileId, InternalVectorStoreFileObjectObject @object, int size, DateTimeOffset createdAt, string vectorStoreId, VectorStoreFileAssociationStatus status, VectorStoreFileAssociationError lastError, FileChunkingStrategy chunkingStrategy, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        FileId = fileId;
        Object = @object;
        Size = size;
        CreatedAt = createdAt;
        VectorStoreId = vectorStoreId;
        Status = status;
        LastError = lastError;
        ChunkingStrategy = chunkingStrategy;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal VectorStoreFileAssociation()
    {
    }
    public DateTimeOffset CreatedAt { get; }
    public string VectorStoreId { get; }
    public VectorStoreFileAssociationStatus Status { get; }
    public VectorStoreFileAssociationError LastError { get; }
}