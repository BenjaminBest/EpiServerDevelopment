using EpiServerDevelopment.Extensions;
using EpiServerDevelopment.Features.Pages;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

namespace EpiServerDevelopment.Features.GlobalLayout
{
    /// <summary>
    /// The PageControllerBase is used as a base class for page controllers to provide properties
    /// </summary>
    /// <typeparam name="TPage">The type of the page.</typeparam>
    /// <seealso cref="EPiServer.Web.Mvc.PageController{TPage}" />
    public class PageControllerBase<TPage> : PageController<TPage>, IControllerSupportsLayout where TPage : PageDataBase
    {
        /// <summary>
        /// Gets or sets the layout model.
        /// </summary>
        /// <value>
        /// The layout model.
        /// </value>
        private Injected<LayoutModel> LayoutModel { get; set; }

        /// <summary>
        /// Gets the page layout.
        /// </summary>
        /// <value>
        /// The page layout.
        /// </value>
        public LayoutModel PageLayout => LayoutModel.Service;

        /// <summary>
        /// Modifies the layout.
        /// </summary>
        /// <param name="layoutModel">The layout model.</param>
        public void AdjustLayout(LayoutModel layoutModel)
        {
            PageContext.Page.As<IPageLayout>().IsNotNull(layoutModel.Map);
        }
    }
}