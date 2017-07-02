using EpiServerDevelopment.Features.Images;
using EPiServer.Core;

namespace EpiServerDevelopment.Features.Teasers
{
    /// <summary>
    /// The class DefaultTemplateViewModel is the default viewmodel for teaser which do not need a specifc model
    /// </summary>
    public class DefaultTemplateViewModel
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the sub title.
        /// </summary>
        /// <value>
        /// The sub title.
        /// </value>
        public string SubTitle { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public XhtmlString Description { get; set; }

        /// <summary>
        /// Gets or sets the button caption.
        /// </summary>
        /// <value>
        /// The button caption.
        /// </value>
        public string ButtonCaption { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        public Image Image { get; set; }

        /// <summary>
        /// Gets or sets the link to the teasered content
        /// </summary>
        /// <value>
        /// The link.
        /// </value>
        public ContentReference Link { get; set; }
    }
}