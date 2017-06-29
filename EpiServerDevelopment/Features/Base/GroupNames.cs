using System.ComponentModel.DataAnnotations;
using EPiServer.DataAnnotations;

namespace EpiServerDevelopment.Features.Base
{
    /// <summary>
    /// TabNames defines the tabs used for categorization
    /// </summary>
    [GroupDefinitions]
    public class TabNames
    {
        [Display(Name = "Teaser", Order = 1)]
        public const string Teaser = "Teaser";

        [Display(Name = "Layout", Order = 2)]
        public const string Layout = "Layout";
    }
}