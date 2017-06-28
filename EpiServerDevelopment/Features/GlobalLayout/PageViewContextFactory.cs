using System.Web.Routing;
using EpiServerDevelopment.Extensions;
using EpiServerDevelopment.Features.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;

namespace EpiServerDevelopment.Features.GlobalLayout
{
    /// <summary>
    /// The PageViewContextFactory gets the startpage and updates the layoutmodel based on the configuration
    /// </summary>
    public class PageViewContextFactory
    {
        /// <summary>
        /// The content loader
        /// </summary>
        private readonly IContentLoader _contentLoader;

        /// <summary>
        /// The page hierarchy resolver
        /// </summary>
        private readonly IPageHierarchyResolver _pageHierarchyResolver;

        /// <summary>
        /// Initializes a new instance of the <see cref="PageViewContextFactory" /> class.
        /// </summary>
        /// <param name="contentLoader">The content loader.</param>
        /// <param name="pageHierarchyResolver">The page hierarchy resolver.</param>
        public PageViewContextFactory(IContentLoader contentLoader, IPageHierarchyResolver pageHierarchyResolver)
        {
            _contentLoader = contentLoader;
            _pageHierarchyResolver = pageHierarchyResolver;
        }

        /// <summary>
        /// Updates the layout model with the current value of the startpage properties 
        /// </summary>
        /// <param name="pageLayout">The page layout.</param>
        /// <param name="currentContentLink">The current content link.</param>
        /// <param name="requestContext">The request context.</param>
        /// <returns></returns>
        public LayoutModel UpdateLayoutModel(LayoutModel pageLayout, ContentReference currentContentLink, RequestContext requestContext)
        {
            var supportsLayout = _pageHierarchyResolver.GetCurrentOrParentPage<IPageLayout>();

            supportsLayout.IsNotNull(pageLayout.Map);

            return pageLayout;
        }
    }
}