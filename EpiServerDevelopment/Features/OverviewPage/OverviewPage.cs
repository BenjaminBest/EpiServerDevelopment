using EpiServerDevelopment.Features.Pages;
using EPiServer.DataAnnotations;

namespace EpiServerDevelopment.Features.OverviewPage
{
    [ContentType(DisplayName = "OverviewPage", GUID = "adc2e236-032c-49bc-a2fb-1f56dafc1200", Description = "The overview page is a distribution page on top of content pages")]
    public class OverviewPage : PageDataBase
    {
    }
}