using EPiServer.Core;

namespace EpiServerDevelopment.Features.Teasers
{
    /// <summary>
    /// The interface ITeaser defines the represenation of a content type in a teaser.
    /// </summary>
    public interface ITeaser
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the sub title.
        /// </summary>
        /// <value>
        /// The sub title.
        /// </value>
        string SubTitle { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        ContentArea Images { get; set; }
    }
}
