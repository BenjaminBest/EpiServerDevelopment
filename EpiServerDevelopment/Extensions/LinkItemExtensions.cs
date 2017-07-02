using EPiServer;
using EPiServer.Core;
using EPiServer.SpecializedProperties;
using EPiServer.Web.Routing;

namespace EpiServerDevelopment.Extensions
{
    /// <summary>
    /// The class LinkItemExtensions provides extension methods for <seealso cref="LinkItem"/>
    /// </summary>
    public static class LinkItemExtensions
    {
        /// <summary>
        /// Returns a content reference for the given link item
        /// </summary>
        /// <param name="linkItem">The link item.</param>
        /// <returns></returns>
        public static ContentReference ToContentReference(this LinkItem linkItem)
        {
            if (linkItem == null)
                return ContentReference.EmptyReference;

            var content = UrlResolver.Current.Route(new UrlBuilder(linkItem.Href));

            return content != null ? content.ContentLink : ContentReference.EmptyReference;
        }
    }
}