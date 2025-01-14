// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// SKU capacity information
    /// Serialized Name: SkuCapacity
    /// </summary>
    public partial class MachineLearningSkuCapacity
    {
        /// <summary> Initializes a new instance of MachineLearningSkuCapacity. </summary>
        internal MachineLearningSkuCapacity()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningSkuCapacity. </summary>
        /// <param name="default">
        /// Gets or sets the default capacity.
        /// Serialized Name: SkuCapacity.default
        /// </param>
        /// <param name="maximum">
        /// Gets or sets the maximum.
        /// Serialized Name: SkuCapacity.maximum
        /// </param>
        /// <param name="minimum">
        /// Gets or sets the minimum.
        /// Serialized Name: SkuCapacity.minimum
        /// </param>
        /// <param name="scaleType">
        /// Gets or sets the type of the scale.
        /// Serialized Name: SkuCapacity.scaleType
        /// </param>
        internal MachineLearningSkuCapacity(int? @default, int? maximum, int? minimum, MachineLearningSkuScaleType? scaleType)
        {
            Default = @default;
            Maximum = maximum;
            Minimum = minimum;
            ScaleType = scaleType;
        }

        /// <summary>
        /// Gets or sets the default capacity.
        /// Serialized Name: SkuCapacity.default
        /// </summary>
        public int? Default { get; }
        /// <summary>
        /// Gets or sets the maximum.
        /// Serialized Name: SkuCapacity.maximum
        /// </summary>
        public int? Maximum { get; }
        /// <summary>
        /// Gets or sets the minimum.
        /// Serialized Name: SkuCapacity.minimum
        /// </summary>
        public int? Minimum { get; }
        /// <summary>
        /// Gets or sets the type of the scale.
        /// Serialized Name: SkuCapacity.scaleType
        /// </summary>
        public MachineLearningSkuScaleType? ScaleType { get; }
    }
}
