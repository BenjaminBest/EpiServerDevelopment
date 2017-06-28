using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EpiServerDevelopment.Extensions;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Routing;

namespace EpiServerDevelopment.Features.Pages
{
    /// <summary>
    /// The PageHierarchyResolver resolves pages by type in the page tree
    /// </summary>
    public class PageHierarchyResolver : IPageHierarchyResolver
    {
        /// <summary>
        /// The page route helper
        /// </summary>
        private readonly IPageRouteHelper _pageRouteHelper;

        /// <summary>
        /// The content repository
        /// </summary>
        private readonly IContentRepository _contentRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="PageHierarchyResolver"/> class.
        /// </summary>
        /// <param name="pageRouteHelper">The page route helper.</param>
        /// <param name="contentRepository"></param>
        public PageHierarchyResolver(IPageRouteHelper pageRouteHelper, IContentRepository contentRepository)
        {
            _pageRouteHelper = pageRouteHelper;
            _contentRepository = contentRepository;
        }

        /// <summary>
        /// Gets the current page if the page type is <typeparamref name="TPage"/>
        /// </summary>
        /// <typeparam name="TPage">The type of the page.</typeparam>
        /// <returns></returns>
        public TPage GetCurrentPage<TPage>() where TPage : class
        {
            return _pageRouteHelper.IsNotNull(p => p.Page as TPage);
        }

        /// <summary>
        /// Gets the parent page if the page type is <typeparamref name="TPage"/>
        /// </summary>
        /// <typeparam name="TPage">The type of the page.</typeparam>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public TPage GetParentPage<TPage>(PageData page) where TPage : class
        {
            if (page == null)
                page = _pageRouteHelper.Page;

            while (page != null && page.ParentLink != PageReference.EmptyReference)
            {
                page = _contentRepository.Get<IContent>(page.ParentLink) as PageData;

                if (page is TPage)
                    return page as TPage;
            }

            return null;
        }

        /// <summary>
        /// Gets the current or parent page if the page type is <typeparamref name="TPage"/>
        /// </summary>
        /// <typeparam name="TPage">The type of the page.</typeparam>
        /// <returns></returns>
        public TPage GetCurrentOrParentPage<TPage>() where TPage : class
        {
            return GetCurrentPage<TPage>() ?? GetParentPage<TPage>(null);
        }
    }
}