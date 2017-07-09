using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EpiServerDevelopment.Features.Base;
using EpiServerDevelopment.Features.Editors;
using EpiServerDevelopment.Features.Editors.StringList;

namespace EpiServerDevelopment.Features.MetaTags
{
    [ContentType(DisplayName = "MetaTagsBlock", GUID = "63b8d709-8b4d-4010-8fec-f4534d41ce2c", Description = "")]
    public class MetaTagsBlock : BlockDataBase, IMetaTags
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [CultureSpecific]
        [Display(
            Name = "Description",
            Description = "The description meta tag",
            GroupName = SystemTabNames.Content)]
        public virtual string Description { get; set; }

        /// <summary>
        /// Gets or sets the keywords. They are merged with the categories.
        /// </summary>
        /// <value>
        /// The keywords.
        /// </value>
        [CultureSpecific]
        [Display(
            Name = "Keywords",
            Description = "The keywords describes the content, when no used the categories are automatically added",
            GroupName = SystemTabNames.Content)]
        [UIHint(CustomUiHints.StringList)]
        [BackingType(typeof(StringListProperty))]
        public virtual IList<string> Keywords { get; set; }

        /// <summary>
        /// Gets or sets the viewport.
        /// </summary>
        /// <value>
        /// The viewport.
        /// </value>
        [CultureSpecific]
        [Display(
            Name = "Viewport",
            Description = "The viewport tag controls the viewport's size and scale. Use width and initial-scale",
            GroupName = SystemTabNames.Content)]
        public virtual string Viewport { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        [Display(
            Name = "Date",
            Description = "The publish date or the date when the content has changed",
            GroupName = SystemTabNames.Content)]
        [UIHint(CustomUiHints.DatePicker)]
        public virtual DateTime? Date { get; set; }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        /// <value>
        /// The author.
        /// </value>
        [Display(
            Name = "Author",
            Description = "The author who has created or changed the content",
            GroupName = SystemTabNames.Content)]
        public virtual string Author { get; set; }
    }
}