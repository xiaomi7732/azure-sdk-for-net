// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Migration db state of an individual database. </summary>
    public readonly partial struct MigrationDbState : IEquatable<MigrationDbState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MigrationDbState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MigrationDbState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string WaitingForCutoverTriggerValue = "WaitingForCutoverTrigger";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string SucceededValue = "Succeeded";
        private const string CancelingValue = "Canceling";

        /// <summary> InProgress. </summary>
        public static MigrationDbState InProgress { get; } = new MigrationDbState(InProgressValue);
        /// <summary> WaitingForCutoverTrigger. </summary>
        public static MigrationDbState WaitingForCutoverTrigger { get; } = new MigrationDbState(WaitingForCutoverTriggerValue);
        /// <summary> Failed. </summary>
        public static MigrationDbState Failed { get; } = new MigrationDbState(FailedValue);
        /// <summary> Canceled. </summary>
        public static MigrationDbState Canceled { get; } = new MigrationDbState(CanceledValue);
        /// <summary> Succeeded. </summary>
        public static MigrationDbState Succeeded { get; } = new MigrationDbState(SucceededValue);
        /// <summary> Canceling. </summary>
        public static MigrationDbState Canceling { get; } = new MigrationDbState(CancelingValue);
        /// <summary> Determines if two <see cref="MigrationDbState"/> values are the same. </summary>
        public static bool operator ==(MigrationDbState left, MigrationDbState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MigrationDbState"/> values are not the same. </summary>
        public static bool operator !=(MigrationDbState left, MigrationDbState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MigrationDbState"/>. </summary>
        public static implicit operator MigrationDbState(string value) => new MigrationDbState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MigrationDbState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MigrationDbState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
