using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EpiServerDevelopment.Features.Pages;

namespace EpiServerDevelopment.Features.StartPage
{
    [ContentType(DisplayName = "StartPage", GUID = "b2298cf3-3b51-4469-a160-014cfcd349ce", Description = "This is the start page")]
    public class StartPage : LayoutPageDataBase
    {
        [CultureSpecific]
        [Display(
            Name = "Main content",
            Description = "The main content",
            GroupName = SystemTabNames.Content)]
        public virtual ContentArea MainContent { get; set; }
    }
}