using System;
using System.Web.Mvc;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;

namespace EpiServerDevelopment.Features.GlobalLayout
{
    /// <summary>
    /// Intercepts actions with view models and populates the view models Layout properties.
    /// </summary>
    /// <remarks>
    /// This filter frees controllers for pages from having to care about common context needed by layouts
    /// and other page framework components allowing the controllers to focus on the specifics for the page types
    /// and actions that they handle. 
    /// </remarks>
    public class PageContextActionFilter : IResultFilter
    {
        /// <summary>
        /// The page view context factory
        /// </summary>
        private readonly PageViewContextFactory _pageViewContextFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="PageContextActionFilter"/> class.
        /// </summary>
        /// <param name="pageViewContextFactory">The page view context factory.</param>
        public PageContextActionFilter(PageViewContextFactory pageViewContextFactory)
        {
            _pageViewContextFactory = pageViewContextFactory;
        }

        /// <summary>
        /// Called before an action result executes.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var currentContentLink = filterContext.RequestContext.GetContentLink();

            if (currentContentLink == null)
                return;

            var pageLayout = ServiceLocator.Current.GetInstance<LayoutModel>();
            _pageViewContextFactory.UpdateLayoutModel(pageLayout, currentContentLink, filterContext.RequestContext);

            var layoutController = filterContext.Controller as IControllerSupportsLayout;
            layoutController?.AdjustLayout(pageLayout);
        }

        /// <summary>Called after an action result executes.</summary>
        /// <param name="filterContext">The filter context.</param>
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }
    }
}