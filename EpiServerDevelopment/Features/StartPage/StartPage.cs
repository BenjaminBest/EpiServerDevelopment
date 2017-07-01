using System.ComponentModel.DataAnnotations;
using EpiServerDevelopment.Features.GlobalLayout;
using EpiServerDevelopment.Features.Validation;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiServerDevelopment.Features.StartPage
{
    [ContentType(DisplayName = "StartPage", GUID = "b2298cf3-3b51-4469-a160-014cfcd349ce", Description = "The start page is the root page of a site and provides layout settings")]
    public class StartPage : LayoutPageDataBase
    {
        [CultureSpecific]
        [Display(
            Name = "Main content",
            Description = "The main content",
            GroupName = SystemTabNames.Content)]
        public virtual ContentArea MainContent { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Call to action",
            Description = "The call to action",
            GroupName = SystemTabNames.Content)]
        [ContentAreaMaxItems(1)]
        public virtual ContentArea CallToAction { get; set; }
    }
}