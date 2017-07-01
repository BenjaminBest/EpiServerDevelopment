using System.Web.Mvc;
using EpiServerDevelopment.Features.GlobalLayout;
using EpiServerDevelopment.Features.Images;
using EPiServer.Web.Mvc;

namespace EpiServerDevelopment.Features.StartPage
{
    /// <summary>
    /// The StartPageController
    /// </summary>
    /// <seealso cref="LayoutPageControllerBase{TPage}" />
    public class StartPageController : LayoutPageControllerBase<StartPage>
    {
        /// <summary>
        /// Index action of this page
        /// </summary>
        /// <param name="currentPage">The current page.</param>
        /// <returns></returns>
        public ActionResult Index(StartPage currentPage)
        {
            var editHints = ViewData.GetEditHints<StartPage, StartPage>();
            editHints.AddConnection(v => PageLayout.MetaHeaderNavigation, c => c.MetaHeaderNavigation);
            editHints.AddConnection(v => PageLayout.MetaFooterNavigation, c => c.MetaFooterNavigation);

            var model = currentPage;

            return View(model);
        }
    }
}