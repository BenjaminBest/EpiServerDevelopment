using System.ComponentModel.DataAnnotations;
using EpiServerDevelopment.Features.Base;
using EpiServerDevelopment.Features.Teasers;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace EpiServerDevelopment.Features.Pages
{
    /// <summary>
    /// PageDataBase is used as a base class for all page types
    /// </summary>
    public abstract class PageDataBase : PageData, ITeaser
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "The title for this page when used in a teaser",
            GroupName = TabNames.Teaser,
            Order = 100)]
        public virtual string Title { get; set; }

        /// <summary>
        /// Gets or sets the sub title.
        /// </summary>
        /// <value>
        /// The sub title.
        /// </value>
        [CultureSpecific]
        [Display(
            Name = "SubTitle",
            Description = "The subtitle for this page when used in a teaser",
            GroupName = TabNames.Teaser,
            Order = 200)]
        public virtual string SubTitle { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [CultureSpecific]
        [Display(
            Name = "Description",
            Description = "The description for this page when used in a teaser",
            GroupName = TabNames.Teaser,
            Order = 300)]
        public virtual XhtmlString Description { get; set; }

        /// <summary>
        /// Gets or sets the button caption.
        /// </summary>
        /// <value>
        /// The button caption.
        /// </value>
        [CultureSpecific]
        [Display(
            Name = "Button Caption",
            Description = "The caption of the button (if available) for this page when used in a teaser",
            GroupName = TabNames.Teaser,
            Order = 400)]
        public virtual string ButtonCaption { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        [Display(
            Name = "Images",
            Description = "The available images for this page when used in a teaser",
            GroupName = TabNames.Teaser,
            Order = 500)]
        [AllowedTypes(typeof(ImageData))]
        public virtual ContentArea Images { get; set; }

        /// <summary>
        /// Sets the default property values on the page data.
        /// </summary>
        /// <param name="contentType">The type of content.</param>
        public override void SetDefaultValues(ContentType contentType)
        {
            Title = PageTypeName;
            SubTitle = $"This is the subtitle of {PageTypeName}";
            Description = new XhtmlString($"This is the description of {PageTypeName}");
            ButtonCaption = "View More";

            base.SetDefaultValues(contentType);
        }
    }
}