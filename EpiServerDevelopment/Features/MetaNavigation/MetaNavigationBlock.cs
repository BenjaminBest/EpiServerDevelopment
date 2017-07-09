using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EpiServerDevelopment.Features.Base;
using EpiServerDevelopment.Features.Pages;

namespace EpiServerDevelopment.Features.MetaNavigation
{
    [ContentType(DisplayName = "MetaNavigationBlock", GUID = "11180a92-3eeb-432b-86c3-d212636cab24", Description = "Displays in the meta navigation in the header",
        AvailableInEditMode = false)]
    public class MetaNavigationBlock : BlockDataBase
    {
        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        /// <value>
        /// The links.
        /// </value>
        [CultureSpecific]
        [Display(
            Name = "Links",
            Description = "The links to be displayed in the meta navigation in the header",
            GroupName = SystemTabNames.Content)]
        [AllowedTypes(typeof(PageDataBase))]
        public virtual ContentArea Links { get; set; }
    }
}