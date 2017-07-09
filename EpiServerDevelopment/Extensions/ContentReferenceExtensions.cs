using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;

namespace EpiServerDevelopment.Extensions
{
    /// <summary>
    /// The class ContentReferenceExtensionsprovides extension methods for content references
    /// </summary>
    public static class ContentReferenceExtensions
    {
        /// <summary>
        /// Gets the content from the given <paramref name="contentReference"/>
        /// </summary>
        /// <param name="contentReference">The content reference.</param>
        /// <returns></returns>
        public static IContent GetContent(this ContentReference contentReference)
        {
            if (contentReference == ContentReference.EmptyReference)
                return null;

            var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();

            return contentRepository.Get<IContent>(contentReference);
        }
    }
}