namespace EpiServerDevelopment.Features.MetaTags
{
    /// <summary>
    /// The class MetaTagsViewModel is used as view model in the metatags view
    /// </summary>
    public class MetaTagsViewModel
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the keywords. They are merged with the categories.
        /// </summary>
        /// <value>
        /// The keywords.
        /// </value>
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or sets the viewport.
        /// </summary>
        /// <value>
        /// The viewport.
        /// </value>
        public string Viewport { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        /// <value>
        /// The author.
        /// </value>
        public string Author { get; set; }
    }
}