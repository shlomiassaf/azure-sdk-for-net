// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.TextAnalytics
{
    /// <summary> The State. </summary>
    public readonly partial struct JobStatus : IEquatable<JobStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="JobStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotstartedValue = "notstarted";
        private const string RunningValue = "running";
        private const string SucceededValue = "succeeded";
        private const string FailedValue = "failed";
        private const string CancelledValue = "cancelled";
        private const string CancellingValue = "cancelling";
        private const string PartiallycompletedValue = "partiallycompleted";

        /// <summary> notstarted. </summary>
        public static JobStatus Notstarted { get; } = new JobStatus(NotstartedValue);
        /// <summary> running. </summary>
        public static JobStatus Running { get; } = new JobStatus(RunningValue);
        /// <summary> succeeded. </summary>
        public static JobStatus Succeeded { get; } = new JobStatus(SucceededValue);
        /// <summary> failed. </summary>
        public static JobStatus Failed { get; } = new JobStatus(FailedValue);
        /// <summary> cancelled. </summary>
        public static JobStatus Cancelled { get; } = new JobStatus(CancelledValue);
        /// <summary> cancelling. </summary>
        public static JobStatus Cancelling { get; } = new JobStatus(CancellingValue);
        /// <summary> partiallycompleted. </summary>
        public static JobStatus Partiallycompleted { get; } = new JobStatus(PartiallycompletedValue);
        /// <summary> Determines if two <see cref="JobStatus"/> values are the same. </summary>
        public static bool operator ==(JobStatus left, JobStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobStatus"/> values are not the same. </summary>
        public static bool operator !=(JobStatus left, JobStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobStatus"/>. </summary>
        public static implicit operator JobStatus(string value) => new JobStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}