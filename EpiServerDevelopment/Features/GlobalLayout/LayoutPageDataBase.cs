using System.ComponentModel.DataAnnotations;
using EpiServerDevelopment.Features.Base;
using EpiServerDevelopment.Features.Images;
using EpiServerDevelopment.Features.MetaNavigation;
using EpiServerDevelopment.Features.Pages;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace EpiServerDevelopment.Features.GlobalLayout
{
    /// <summary>
    /// LayoutPageDataBase is used as a base class for all page types that support the layout settings
    /// </summary>
    public abstract class LayoutPageDataBase : PageDataBase, IPageLayout
    {
        [Display(
            Name = "Header Meta Navigation",
            Description = "The meta header navigation",
            GroupName = TabNames.Layout)]
        public virtual MetaNavigationBlock MetaHeaderNavigation { get; set; }

        [Display(
            Name = "Footer Meta Navigation",
            Description = "The meta footer navigation",
            GroupName = TabNames.Layout)]
        public virtual MetaNavigationBlock MetaFooterNavigation { get; set; }

        [Display(
            Name = "Logo",
            Description = "The image used for the logo",
            GroupName = TabNames.Layout)]
        [UIHint("Image")]
        [AllowedTypes(typeof(Image))]
        public virtual ContentReference Logo { get; set; }

        [ScaffoldColumn(true)]
        public virtual ContentReference StartPage { get; set; }
    }
}