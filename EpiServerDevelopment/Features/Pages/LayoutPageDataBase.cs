using System.ComponentModel.DataAnnotations;
using EpiServerDevelopment.Features.Base;
using EpiServerDevelopment.Features.GlobalLayout;
using EpiServerDevelopment.Features.MetaNavigation;

namespace EpiServerDevelopment.Features.Pages
{
    /// <summary>
    /// LayoutPageDataBase is used as a base class for all page types that support the layout settings
    /// </summary>
    public abstract class LayoutPageDataBase : PageDataBase, IPageLayout
    {
        [Display(
            Name = "Header Meta Navigation",
            Description = "The meta header navigation",
            GroupName = TabNames.Navigation)]
        public virtual MetaNavigationBlock MetaHeaderNavigation { get; set; }

        [Display(
            Name = "Footer Meta Navigation",
            Description = "The meta footer navigation",
            GroupName = TabNames.Navigation)]
        public virtual MetaNavigationBlock MetaFooterNavigation { get; set; }
    }
}