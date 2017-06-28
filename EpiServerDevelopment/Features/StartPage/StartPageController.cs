using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EpiServerDevelopment.Features.Pages;

namespace EpiServerDevelopment.Features.StartPage
{
    /// <summary>
    /// The StartPageController
    /// </summary>
    /// <seealso cref="EPiServer.Web.Mvc.PageController{StartPage}" />
    public class StartPageController : PageController<StartPage>
    {
        /// <summary>
        /// Index action of this page
        /// </summary>
        /// <param name="currentPage">The current page.</param>
        /// <returns></returns>
        public ActionResult Index(StartPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);

            return View(model);
        }
    }
}