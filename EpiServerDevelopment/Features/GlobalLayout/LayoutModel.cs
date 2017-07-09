using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EpiServerDevelopment.Features.MetaNavigation;
using EpiServerDevelopment.Features.MetaTags;
using EpiServerDevelopment.Features.Pages;

namespace EpiServerDevelopment.Features.GlobalLayout
{
    /// <summary>
    /// The class LayoutModel contains all global layout settings which are used to build the layout
    /// </summary>
    public class LayoutModel : IPageLayout
    {
        /// <summary>
        /// Gets or sets the meta header navigation.
        /// </summary>
        /// <value>
        /// The meta header navigation.
        /// </value>
        public MetaNavigationBlock MetaHeaderNavigation { get; set; }

        /// <summary>
        /// Gets or sets the meta footer navigation.
        /// </summary>
        /// <value>
        /// The meta footer navigation.
        /// </value>
        public MetaNavigationBlock MetaFooterNavigation { get; set; }

        /// <summary>
        /// Gets or sets the logo.
        /// </summary>
        /// <value>
        /// The logo.
        /// </value>
        [UIHint(UIHint.Image)]
        public ContentReference Logo { get; set; }

        /// <summary>
        /// Gets or sets the start page.
        /// </summary>
        /// <value>
        /// The start page.
        /// </value>
        public ContentReference StartPage { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the meta tags.
        /// </summary>
        /// <value>
        /// The meta tags.
        /// </value>
        public MetaTagsBlock MetaTags { get; set; }

        /// <summary>
        /// Maps the properties of the specified page to this layout model
        /// </summary>
        /// <param name="page">The page.</param>
        public void Map(IPageLayout page)
        {
            MetaHeaderNavigation = page.MetaHeaderNavigation;
            MetaFooterNavigation = page.MetaFooterNavigation;
            Logo = page.Logo;
            StartPage = ((IContent)page).ContentLink;

            //Current Page
            //TODO: Mappings from current page should be moved somewhere else
            var currentPage = ServiceLocator.Current.GetInstance<IPageHierarchyResolver>()
                .GetCurrentPage<PageDataBase>();

            Title = currentPage.SubTitle;
            MetaTags = currentPage.MetaTags;
        }
    }
}