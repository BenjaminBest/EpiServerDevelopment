using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EpiServerDevelopment.Features.Base;

namespace EpiServerDevelopment.Features.MetaNavigation
{
    [ContentType(DisplayName = "MetaNavigationBlock", GUID = "11180a92-3eeb-432b-86c3-d212636cab24", Description = "Displays in the meta navigation in the header",
        AvailableInEditMode = false)]
    public class MetaNavigationBlock : BlockDataBase
    {
        [CultureSpecific]
        [Display(
            Name = "Links",
            Description = "The links to be displayed in the meta navigation in the header",
            GroupName = SystemTabNames.Content)]
        public virtual LinkItemCollection Links { get; set; }
    }
}