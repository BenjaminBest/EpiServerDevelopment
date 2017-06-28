﻿using EpiServerDevelopment.Features.MetaNavigation;

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
        /// Maps the properties of the specified page to this layout model
        /// </summary>
        /// <param name="page">The page.</param>
        public void Map(IPageLayout page)
        {
            MetaHeaderNavigation = page.MetaHeaderNavigation;
            MetaFooterNavigation = page.MetaFooterNavigation;
        }
    }
}