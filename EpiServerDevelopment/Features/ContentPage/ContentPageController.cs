using System.Web.Mvc;
using EPiServer.Web.Mvc;

namespace EpiServerDevelopment.Features.ContentPage
{
    /// <summary>
    /// The content page controller
    /// </summary>
    /// <seealso cref="EPiServer.Web.Mvc.PageController{ContentPage}" />
    public class ContentPageController : PageController<ContentPage>
    {
        /// <summary>
        /// Index action of this page
        /// </summary>
        /// <param name="currentPage">The current page.</param>
        /// <returns></returns>
        public ActionResult Index(ContentPage currentPage)
        {
            return View(currentPage);
        }
    }
}