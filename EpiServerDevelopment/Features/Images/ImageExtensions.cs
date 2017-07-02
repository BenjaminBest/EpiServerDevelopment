using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiServerDevelopment.Features.Images
{
    /// <summary>
    /// The class ImageExtensions provides extension methods for image or image lists
    /// </summary>
    public static class ImageExtensions
    {
        /// <summary>
        /// Returns one image or null which has the given <paramref name="minWidth" />.
        /// </summary>
        /// <param name="images">The images.</param>
        /// <param name="minWidth">The minimum width.</param>
        /// <returns>
        /// Image
        /// </returns>
        public static Image OfWidth(this IEnumerable<Image> images, int minWidth)
        {
            return images.FirstOrDefault(i => int.Parse(i.Width) == minWidth);
        }


        /// <summary>
        /// Returns one image or null which has the given <paramref name="minHeight" />.
        /// </summary>
        /// <param name="images">The images.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <returns>
        /// Image
        /// </returns>
        public static Image OfHeight(this IEnumerable<Image> images, int minHeight)
        {
            return images.FirstOrDefault(i => int.Parse(i.Height) == minHeight);
        }

        /// <summary>
        /// Returns one image or null which has the given <paramref name="minHeight" />. and <paramref name="minWidth" />
        /// </summary>
        /// <param name="images">The images.</param>
        /// <param name="minWidth">The minimum width.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <returns>
        /// Image
        /// </returns>
        public static Image OfSize(this IEnumerable<Image> images, int minWidth, int minHeight)
        {
            return images.FirstOrDefault(i => int.Parse(i.Height) == minHeight && int.Parse(i.Width) == minWidth);
        }
    }
}