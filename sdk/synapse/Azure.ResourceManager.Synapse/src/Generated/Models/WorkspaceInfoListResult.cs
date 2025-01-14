// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> List of workspaces. </summary>
    internal partial class WorkspaceInfoListResult
    {
        /// <summary> Initializes a new instance of WorkspaceInfoListResult. </summary>
        internal WorkspaceInfoListResult()
        {
            Value = new ChangeTrackingList<WorkspaceData>();
        }

        /// <summary> Initializes a new instance of WorkspaceInfoListResult. </summary>
        /// <param name="nextLink"> Link to the next page of results. </param>
        /// <param name="value"> List of workspaces. </param>
        internal WorkspaceInfoListResult(string nextLink, IReadOnlyList<WorkspaceData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
        /// <summary> List of workspaces. </summary>
        public IReadOnlyList<WorkspaceData> Value { get; }
    }
}
