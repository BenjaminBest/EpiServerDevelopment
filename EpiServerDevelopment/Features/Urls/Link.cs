using EPiServer;

namespace EpiServerDevelopment.Features.Urls
{
    /// <summary>
    /// The class Link defines a link 
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the caption.
        /// </summary>
        /// <value>
        /// The caption.
        /// </value>
        public string Caption { get; set; }

        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        /// <value>
        /// The target.
        /// </value>
        public LinkTargetType Target { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Link"/> class.
        /// </summary>
        /// <param name="caption">The caption.</param>
        /// <param name="href">The url</param>
        public Link(string caption, string href)
        {
            Caption = caption;
            Href = href;
            Target = LinkTargetType.Self;
        }
    }
}