using System.ComponentModel.DataAnnotations;
using EpiServerDevelopment.Features.Pages;
using EpiServerDevelopment.Features.Validation;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiServerDevelopment.Features.ContentPage
{
    [ContentType(DisplayName = "ContentPage", GUID = "E94C06CC-CFA3-4A7F-8D6D-D352D26D5C52", Description = "The content page contains generic content")]
    public class ContentPage : PageDataBase
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