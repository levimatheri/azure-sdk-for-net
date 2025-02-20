// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Collection of alerts. </summary>
    internal partial class AlertCollection
    {
        /// <summary> Initializes a new instance of AlertCollection. </summary>
        internal AlertCollection()
        {
            Value = new ChangeTrackingList<AlertData>();
        }

        /// <summary> Initializes a new instance of AlertCollection. </summary>
        /// <param name="value"> The list of alerts. </param>
        /// <param name="nextLink"> The value of next link. </param>
        internal AlertCollection(IReadOnlyList<AlertData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of alerts. </summary>
        public IReadOnlyList<AlertData> Value { get; }
        /// <summary> The value of next link. </summary>
        public string NextLink { get; }
    }
}
