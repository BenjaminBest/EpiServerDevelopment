using System.Collections.Generic;
using EpiServerDevelopment.Features.Urls;

namespace EpiServerDevelopment.Features.MetaNavigation
{
    /// <summary>
    /// The viewmodel of the meta navigation block
    /// </summary>
    public class MetaNavigationBlockViewModel
    {
        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        /// <value>
        /// The links.
        /// </value>
        public IEnumerable<Link> Links { get; set; }
    }
}