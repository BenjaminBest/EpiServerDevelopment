﻿using EPiServer.Core;

namespace EpiServerDevelopment.Features.Header
{
    /// <summary>
    /// The interface IHasHeader defines all properties for the header
    /// </summary>
    public interface IHasHeader
    {
        /// <summary>
        /// Gets or sets the logo.
        /// </summary>
        /// <value>
        /// The logo.
        /// </value>
        ContentReference Logo { get; set; }

        /// <summary>
        /// Gets or sets the start page.
        /// </summary>
        /// <value>
        /// The start page.
        /// </value>
        ContentReference StartPage { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        string Title { get; set; }
    }
}