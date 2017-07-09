using System.Collections.Generic;
using System.Drawing;

namespace EpiServerDevelopment.Features.Teasers
{
    /// <summary>
    /// The class DefaultImageDimensions provides image dimensions for teasers who used the default resolver
    /// </summary>
    public static class DefaultImageDimensions
    {
        /// <summary>
        /// The dimensions
        /// </summary>
        private static readonly Dictionary<string, Size> Dimensions = new Dictionary<string, Size>();

        /// <summary>
        /// Initializes the <see cref="DefaultImageDimensions"/> class with all available teaser - image size variations
        /// </summary>
        static DefaultImageDimensions()
        {
            //TODO: Initialize automatically
            Dimensions.Add("CallToActionTeaser", new Size(1298, 312));
            Dimensions.Add("RightTextParallaxTeaser", new Size(2560, 1564));
        }

        /// <summary>
        /// Gets the dimension for tag or if no dimension found returns a default value
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <returns>Width and Height</returns>
        public static Size GetDimensionForTag(string tag)
        {
            return Dimensions.ContainsKey(tag) ? Dimensions[tag] : Size.Empty;
        }
    }
}