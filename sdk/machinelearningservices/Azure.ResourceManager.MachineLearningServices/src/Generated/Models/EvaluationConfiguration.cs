// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The EvaluationConfiguration. </summary>
    public partial class EvaluationConfiguration
    {
        /// <summary> Initializes a new instance of EvaluationConfiguration. </summary>
        /// <param name="primaryMetricName"> . </param>
        /// <param name="primaryMetricGoal"> Defines supported metric goals for hyperparameter tuning. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="primaryMetricName"/> is null. </exception>
        public EvaluationConfiguration(string primaryMetricName, PrimaryMetricGoal primaryMetricGoal)
        {
            if (primaryMetricName == null)
            {
                throw new ArgumentNullException(nameof(primaryMetricName));
            }

            PrimaryMetricName = primaryMetricName;
            PrimaryMetricGoal = primaryMetricGoal;
        }

        public string PrimaryMetricName { get; set; }
        /// <summary> Defines supported metric goals for hyperparameter tuning. </summary>
        public PrimaryMetricGoal PrimaryMetricGoal { get; set; }
    }
}