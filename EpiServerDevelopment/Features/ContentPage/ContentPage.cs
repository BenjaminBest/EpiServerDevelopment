using System.ComponentModel.DataAnnotations;
using EpiServerDevelopment.Features.Pages;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiServerDevelopment.Features.ContentPage
{
    [ContentType(DisplayName = "ContactPage", GUID = "E94C06CC-CFA3-4A7F-8D6D-D352D26D5C52", Description = "The contact page provides possibilities to contact the site owner")]
    public class ContentPage : PageDataBase
    {
        [CultureSpecific]
        [Display(
            Name = "Main content",
            Description = "The main content",
            GroupName = SystemTabNames.Content)]
        public virtual ContentArea MainContent { get; set; }
    }
}