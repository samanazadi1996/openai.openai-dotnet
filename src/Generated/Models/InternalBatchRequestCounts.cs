// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Batch;

internal partial class InternalBatchRequestCounts
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    internal InternalBatchRequestCounts(int total, int completed, int failed)
    {
        Total = total;
        Completed = completed;
        Failed = failed;
    }

    internal InternalBatchRequestCounts(int total, int completed, int failed, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Total = total;
        Completed = completed;
        Failed = failed;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal InternalBatchRequestCounts()
    {
    }

    public int Total { get; }
    public int Completed { get; }
    public int Failed { get; }
}