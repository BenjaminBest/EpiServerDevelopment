using EpiServerDevelopment.Extensions;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;

namespace EpiServerDevelopment.Features.Images
{
    /// <summary>
    /// The class ContentReferenceExtensions provides extension methods for content references
    /// </summary>
    public static class ContentReferenceExtensions
    {
        /// <summary>
        /// Returns the image based on the given <paramref name="content"/>
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        public static Image AsImage(this ContentReference content)
        {
            var locator = ServiceLocator.Current.GetInstance<IContentLoader>();

            return content.IsNotNull(c => locator.Get<Image>(c));
        }
    }
}