// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.FineTuning;

internal partial class InternalFineTuningIntegrationWandb : InternalFineTuningIntegration
{
    internal InternalFineTuningIntegrationWandb(FineTuningIntegrationWandbWandb wandb)
    {
        Argument.AssertNotNull(wandb, nameof(wandb));

        Type = "wandb";
        Wandb = wandb;
    }

    internal InternalFineTuningIntegrationWandb(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, FineTuningIntegrationWandbWandb wandb) : base(type, serializedAdditionalRawData)
    {
        Wandb = wandb;
    }

    internal InternalFineTuningIntegrationWandb()
    {
    }

    public FineTuningIntegrationWandbWandb Wandb { get; }
}