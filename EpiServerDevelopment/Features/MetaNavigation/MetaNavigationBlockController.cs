using System.Linq;
using System.Web.Mvc;
using EpiServerDevelopment.Extensions;
using EPiServer.Web.Mvc;
using EpiServerDevelopment.Features.Urls;
using EPiServer.Web.Routing;

namespace EpiServerDevelopment.Features.MetaNavigation
{
    /// <summary>
    /// The controller of the meta navigation block
    /// </summary>
    /// <seealso cref="EPiServer.Web.Mvc.BlockController{MetaNavigationBlock}" />
    public class MetaNavigationBlockController : BlockController<MetaNavigationBlock>
    {
        /// <summary>
        /// Index action of the specified current block.
        /// </summary>
        /// <param name="currentBlock">The current block.</param>
        /// <returns></returns>
        public override ActionResult Index(MetaNavigationBlock currentBlock)
        {
            var model = new MetaNavigationBlockViewModel
            {
                Links = currentBlock.Links.IsNotNull(l => l.Select(ll => new Link(ll.Text, UrlResolver.Current.GetUrl(ll.ToContentReference())))) ?? Enumerable.Empty<Link>()
            };

            return PartialView(model);
        }
    }
}
