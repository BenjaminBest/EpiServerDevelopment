namespace EpiServerDevelopment.Features.MetaNavigation
{
    /// <summary>
    /// The interface IPageMetaNavigation defines a meta navigation
    /// </summary>
    public interface IPageMetaNavigation
    {
        /// <summary>
        /// Gets or sets the links for the header meta navigation.
        /// </summary>
        /// <value>
        /// The links.
        /// </value>
        MetaNavigationBlock MetaHeaderNavigation { get; set; }

        /// <summary>
        /// Gets or sets the links for the footer meta navigation.
        /// </summary>
        /// <value>
        /// The links.
        /// </value>
        MetaNavigationBlock MetaFooterNavigation { get; set; }
    }
}