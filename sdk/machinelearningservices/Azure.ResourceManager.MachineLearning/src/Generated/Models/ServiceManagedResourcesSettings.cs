// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The ServiceManagedResourcesSettings.
    /// Serialized Name: ServiceManagedResourcesSettings
    /// </summary>
    internal partial class ServiceManagedResourcesSettings
    {
        /// <summary> Initializes a new instance of ServiceManagedResourcesSettings. </summary>
        public ServiceManagedResourcesSettings()
        {
        }

        /// <summary> Initializes a new instance of ServiceManagedResourcesSettings. </summary>
        /// <param name="cosmosDb">
        /// The settings for the service managed cosmosdb account.
        /// Serialized Name: ServiceManagedResourcesSettings.cosmosDb
        /// </param>
        internal ServiceManagedResourcesSettings(CosmosDbSettings cosmosDb)
        {
            CosmosDb = cosmosDb;
        }

        /// <summary>
        /// The settings for the service managed cosmosdb account.
        /// Serialized Name: ServiceManagedResourcesSettings.cosmosDb
        /// </summary>
        internal CosmosDbSettings CosmosDb { get; set; }
        /// <summary>
        /// The throughput of the collections in cosmosdb database
        /// Serialized Name: CosmosDbSettings.collectionsThroughput
        /// </summary>
        public int? CosmosDbCollectionsThroughput
        {
            get => CosmosDb is null ? default : CosmosDb.CollectionsThroughput;
            set
            {
                if (CosmosDb is null)
                    CosmosDb = new CosmosDbSettings();
                CosmosDb.CollectionsThroughput = value;
            }
        }
    }
}
