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
        /// Gets or sets the content loader.
        /// </summary>
        /// <value>
        /// The content loader.
        /// </value>
        private static Injected<IContentLoader> ContentLoader { get; set; }

        /// <summary>
        /// Returns the image based on the given <paramref name="content"/>
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        public static Image AsImage(this ContentReference content)
        {
            return content == null ? null : content.IsNotNull(c => ContentLoader.Service.Get<Image>(c));
        }
    }
}