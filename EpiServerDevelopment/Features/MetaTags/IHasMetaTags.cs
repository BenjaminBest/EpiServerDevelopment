namespace EpiServerDevelopment.Features.MetaTags
{
    /// <summary>
    /// The interface IHasMetaTags defines a list of meta tags
    /// </summary>
    public interface IHasMetaTags
    {
        /// <summary>
        /// Gets or sets the meta tags.
        /// </summary>
        /// <value>
        /// The meta tags.
        /// </value>
        MetaTagsBlock MetaTags { get; set; }
    }
}
