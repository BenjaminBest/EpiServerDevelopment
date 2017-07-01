using System.Collections.Generic;
using System.Linq;
using Castle.Core.Internal;
using EPiServer.Core;

namespace EpiServerDevelopment.Features.Images
{
    /// <summary>
    /// The class ContentAreaExtensions provides extension methods for content areas
    /// </summary>
    public static class ContentAreaExtensions
    {
        /// <summary>
        /// Returns the images based on the given <paramref name="contentArea"/> content area.
        /// </summary>
        /// <param name="contentArea">The content area.</param>
        /// <returns></returns>
        public static IEnumerable<Image> AsImages(this ContentArea contentArea)
        {
            if (contentArea == null || contentArea.FilteredItems.IsNullOrEmpty())
                return Enumerable.Empty<Image>();

            return contentArea.Items.Select(i => i.ContentLink.AsImage());
        }
    }
}