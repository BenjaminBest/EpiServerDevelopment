using System.ComponentModel.DataAnnotations;
using EpiServerDevelopment.Features.Pages;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiServerDevelopment.Features.ContentPage
{
    [ContentType(DisplayName = "ContactPage", GUID = "49713820-7478-45cb-b569-734dc61e44d7", Description = "The contact page provides possibilities to contact the site owner")]
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