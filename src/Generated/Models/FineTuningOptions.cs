// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.FineTuning;

internal partial class FineTuningOptions
{
    internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
    public FineTuningOptions(InternalCreateFineTuningJobRequestModel model, string trainingFile)
    {
        Argument.AssertNotNull(trainingFile, nameof(trainingFile));

        Model = model;
        TrainingFile = trainingFile;
        Integrations = new ChangeTrackingList<FineTuningIntegration>();
    }

    internal FineTuningOptions(InternalCreateFineTuningJobRequestModel model, string trainingFile, HyperparameterOptions hyperparameters, string suffix, string validationFile, IList<FineTuningIntegration> integrations, int? seed, IDictionary<string, BinaryData> serializedAdditionalRawData)
    {
        Model = model;
        TrainingFile = trainingFile;
        Hyperparameters = hyperparameters;
        Suffix = suffix;
        ValidationFile = validationFile;
        Integrations = integrations;
        Seed = seed;
        SerializedAdditionalRawData = serializedAdditionalRawData;
    }

    internal FineTuningOptions()
    {
    }

    public InternalCreateFineTuningJobRequestModel Model { get; }
    public string TrainingFile { get; }
    public HyperparameterOptions Hyperparameters { get; set; }
    public string Suffix { get; set; }
    public string ValidationFile { get; set; }
    public IList<FineTuningIntegration> Integrations { get; set; }
    public int? Seed { get; set; }
}