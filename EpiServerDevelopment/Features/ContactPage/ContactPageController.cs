using System.Web.Mvc;
using EPiServer.Web.Mvc;

namespace EpiServerDevelopment.Features.ContactPage
{
    /// <summary>
    /// The contact page controller
    /// </summary>
    /// <seealso cref="EPiServer.Web.Mvc.PageController{ContactPage}" />
    public class ContactPageController : PageController<ContactPage>
    {
        /// <summary>
        /// Index action of this page
        /// </summary>
        /// <param name="currentPage">The current page.</param>
        /// <returns></returns>
        public ActionResult Index(ContactPage currentPage)
        {
            return View(currentPage);
        }
    }
}