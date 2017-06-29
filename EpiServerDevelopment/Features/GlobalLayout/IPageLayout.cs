using EpiServerDevelopment.Features.Header;
using EpiServerDevelopment.Features.MetaNavigation;

namespace EpiServerDevelopment.Features.GlobalLayout
{
    /// <summary>
    /// The interface IPageLayout defines the information needed for a global layout
    /// </summary>
    /// <seealso cref="IHasPageMetaNavigation" />
    public interface IPageLayout : IHasPageMetaNavigation, IHasHeader
    {
    }
}