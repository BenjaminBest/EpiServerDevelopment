using System.Web.Mvc;
using EPiServer.Web.Mvc;

namespace EpiServerDevelopment.Features.OverviewPage
{
    /// <summary>
    /// The overview page controller
    /// </summary>
    /// <seealso cref="EPiServer.Web.Mvc.PageController{OverviewPage}" />
    public class OverviewPageController : PageController<OverviewPage>
    {
        /// <summary>
        /// Index action of this page
        /// </summary>
        /// <param name="currentPage">The current page.</param>
        /// <returns></returns>
        public ActionResult Index(OverviewPage currentPage)
        {
            return View(currentPage);
        }
    }
}