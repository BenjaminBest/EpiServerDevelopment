using System.Collections.Generic;
using System.Linq;
using EPiServer.Core;

namespace EpiServerDevelopment.Extensions
{
    /// <summary>
    /// The class ContentAreaExtensions provides extension methods for a content area.
    /// </summary>
    public static class ContentAreaExtensions
    {
        /// <summary>
        /// Returns the filtered items savely, if the content area is null an empty collection will be returned.
        /// </summary>
        /// <param name="contentArea">The content area.</param>
        /// <returns></returns>
        public static IEnumerable<ContentAreaItem> FilteredItemsSafe(this ContentArea contentArea)
        {
            return contentArea == null ? Enumerable.Empty<ContentAreaItem>() : contentArea.FilteredItems;
        }
    }
}