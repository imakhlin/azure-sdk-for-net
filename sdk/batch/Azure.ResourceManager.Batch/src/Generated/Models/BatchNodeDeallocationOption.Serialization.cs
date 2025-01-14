// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class BatchNodeDeallocationOptionExtensions
    {
        public static string ToSerialString(this BatchNodeDeallocationOption value) => value switch
        {
            BatchNodeDeallocationOption.Requeue => "Requeue",
            BatchNodeDeallocationOption.Terminate => "Terminate",
            BatchNodeDeallocationOption.TaskCompletion => "TaskCompletion",
            BatchNodeDeallocationOption.RetainedData => "RetainedData",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchNodeDeallocationOption value.")
        };

        public static BatchNodeDeallocationOption ToBatchNodeDeallocationOption(this string value)
        {
            if (string.Equals(value, "Requeue", StringComparison.InvariantCultureIgnoreCase)) return BatchNodeDeallocationOption.Requeue;
            if (string.Equals(value, "Terminate", StringComparison.InvariantCultureIgnoreCase)) return BatchNodeDeallocationOption.Terminate;
            if (string.Equals(value, "TaskCompletion", StringComparison.InvariantCultureIgnoreCase)) return BatchNodeDeallocationOption.TaskCompletion;
            if (string.Equals(value, "RetainedData", StringComparison.InvariantCultureIgnoreCase)) return BatchNodeDeallocationOption.RetainedData;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchNodeDeallocationOption value.");
        }
    }
}
