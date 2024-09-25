// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants;

public partial class RunStep
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    internal RunStep(string id, DateTimeOffset createdAt, string assistantId, string threadId, string runId, RunStepType type, RunStepStatus status, RunStepDetails details, RunStepError lastError, DateTimeOffset? expiredAt, DateTimeOffset? cancelledAt, DateTimeOffset? failedAt, DateTimeOffset? completedAt, IReadOnlyDictionary<string, string> metadata, RunStepTokenUsage usage)
    {
        Argument.AssertNotNull(id, nameof(id));
        Argument.AssertNotNull(assistantId, nameof(assistantId));
        Argument.AssertNotNull(threadId, nameof(threadId));
        Argument.AssertNotNull(runId, nameof(runId));
        Argument.AssertNotNull(details, nameof(details));

        Id = id;
        CreatedAt = createdAt;
        AssistantId = assistantId;
        ThreadId = threadId;
        RunId = runId;
        Type = type;
        Status = status;
        Details = details;
        LastError = lastError;
        ExpiredAt = expiredAt;
        CancelledAt = cancelledAt;
        FailedAt = failedAt;
        CompletedAt = completedAt;
        Metadata = metadata;
        Usage = usage;
    }

    internal RunStep(string id, InternalRunStepObjectObject @object, DateTimeOffset createdAt, string assistantId, string threadId, string runId, RunStepType type, RunStepStatus status, RunStepDetails details, RunStepError lastError, DateTimeOffset? expiredAt, DateTimeOffset? cancelledAt, DateTimeOffset? failedAt, DateTimeOffset? completedAt, IReadOnlyDictionary<string, string> metadata, RunStepTokenUsage usage, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Id = id;
        Object = @object;
        CreatedAt = createdAt;
        AssistantId = assistantId;
        ThreadId = threadId;
        RunId = runId;
        Type = type;
        Status = status;
        Details = details;
        LastError = lastError;
        ExpiredAt = expiredAt;
        CancelledAt = cancelledAt;
        FailedAt = failedAt;
        CompletedAt = completedAt;
        Metadata = metadata;
        Usage = usage;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal RunStep()
    {
    }

    public string Id { get; }

    public DateTimeOffset CreatedAt { get; }
    public string AssistantId { get; }
    public string ThreadId { get; }
    public string RunId { get; }
    public RunStepType Type { get; }
    public RunStepStatus Status { get; }
    public RunStepError LastError { get; }
    public DateTimeOffset? ExpiredAt { get; }
    public DateTimeOffset? CancelledAt { get; }
    public DateTimeOffset? FailedAt { get; }
    public DateTimeOffset? CompletedAt { get; }
    public IReadOnlyDictionary<string, string> Metadata { get; }
    public RunStepTokenUsage Usage { get; }
}