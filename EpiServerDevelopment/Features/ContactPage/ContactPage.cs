using System.ComponentModel.DataAnnotations;
using EpiServerDevelopment.Features.Pages;
using EpiServerDevelopment.Features.Validation;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiServerDevelopment.Features.ContactPage
{
    [ContentType(DisplayName = "ContactPage", GUID = "49713820-7478-45cb-b569-734dc61e44d7", Description = "The contact page provides possibilities to contact the site owner")]
    public class ContactPage : PageDataBase
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