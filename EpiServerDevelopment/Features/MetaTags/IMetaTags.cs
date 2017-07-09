using System;
using System.Collections.Generic;

namespace EpiServerDevelopment.Features.MetaTags
{
    /// <summary>
    /// The interface IMetaTags defines meta information for every page
    /// </summary>
    public interface IMetaTags
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the keywords. They are merged with the categories.
        /// </summary>
        /// <value>
        /// The keywords.
        /// </value>
        IList<string> Keywords { get; set; }

        /// <summary>
        /// Gets or sets the viewport.
        /// </summary>
        /// <value>
        /// The viewport.
        /// </value>
        string Viewport { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        DateTime? Date { get; set; }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        /// <value>
        /// The author.
        /// </value>
        string Author { get; set; }
    }
}
