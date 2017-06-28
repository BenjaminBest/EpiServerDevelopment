using System.ComponentModel.DataAnnotations;
using EPiServer.DataAnnotations;

namespace EpiServerDevelopment.Features.Base
{
    [GroupDefinitions]
    public class TabNames
    {
        [Display(Name = "Navigation", Order = 1)]
        public const string Navigation = "Navigation";
    }
}