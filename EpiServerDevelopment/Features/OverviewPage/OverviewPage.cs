using System.ComponentModel.DataAnnotations;
using EpiServerDevelopment.Features.Pages;
using EpiServerDevelopment.Features.Validation;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiServerDevelopment.Features.OverviewPage
{
    [ContentType(DisplayName = "OverviewPage", GUID = "adc2e236-032c-49bc-a2fb-1f56dafc1200", Description = "The overview page is a distribution page on top of content pages")]
    public class OverviewPage : PageDataBase
    {
        [CultureSpecific]
        [Display(
            Name = "Call to action",
            Description = "The call to action",
            GroupName = SystemTabNames.Content)]
        [ContentAreaMaxItems(1)]
        public virtual ContentArea CallToAction { get; set; }
    }
}