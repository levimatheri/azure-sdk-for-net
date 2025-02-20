// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> A usage model. </summary>
    public partial class StorageCacheUsageModel
    {
        /// <summary> Initializes a new instance of StorageCacheUsageModel. </summary>
        internal StorageCacheUsageModel()
        {
        }

        /// <summary> Initializes a new instance of StorageCacheUsageModel. </summary>
        /// <param name="display"> Localized information describing this usage model. </param>
        /// <param name="modelName"> Non-localized keyword name for this usage model. </param>
        /// <param name="targetType"> The type of Storage Target to which this model is applicable (only nfs3 as of this version). </param>
        internal StorageCacheUsageModel(StorageCacheUsageModelDisplay display, string modelName, string targetType)
        {
            Display = display;
            ModelName = modelName;
            TargetType = targetType;
        }

        /// <summary> Localized information describing this usage model. </summary>
        internal StorageCacheUsageModelDisplay Display { get; }
        /// <summary> String to display for this usage model. </summary>
        public string DisplayDescription
        {
            get => Display?.Description;
        }

        /// <summary> Non-localized keyword name for this usage model. </summary>
        public string ModelName { get; }
        /// <summary> The type of Storage Target to which this model is applicable (only nfs3 as of this version). </summary>
        public string TargetType { get; }
    }
}
