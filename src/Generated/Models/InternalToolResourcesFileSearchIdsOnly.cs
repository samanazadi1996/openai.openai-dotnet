// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

internal partial class InternalToolResourcesFileSearchIdsOnly
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    public InternalToolResourcesFileSearchIdsOnly()
    {
        VectorStoreIds = new ChangeTrackingList<string>();
    }

    internal InternalToolResourcesFileSearchIdsOnly(IList<string> vectorStoreIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        VectorStoreIds = vectorStoreIds;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    public IList<string> VectorStoreIds { get; }
}