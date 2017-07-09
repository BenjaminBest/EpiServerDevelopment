using System.Collections.Generic;
using System.Web.Mvc;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EpiServerDevelopment.Extensions;
using EpiServerDevelopment.Features.Pages;
using EpiServerDevelopment.Features.TemplateResolver;

namespace EpiServerDevelopment.Features.DisplayOptions
{
    /// <summary>
    /// The DisplayOptionsPartialContentController renders derivations of PageDataBase based on a render tag set by display options
    /// </summary>
    /// <seealso cref="EPiServer.Web.Mvc.PartialContentController{PageDataBase}" />
    [TemplateDescriptor(TemplateTypeCategory = TemplateTypeCategories.MvcPartialController, Inherited = true)]
    public class DisplayOptionsPartialContentController : PartialContentController<PageDataBase>
    {
        /// <summary>
        /// The template resolver model factory
        /// </summary>
        private readonly ITemplateResolverRegistry _templateResolverModelFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayOptionsPartialContentController"/> class.
        /// </summary>
        public DisplayOptionsPartialContentController()
        {
            _templateResolverModelFactory = ServiceLocator.Current.GetInstance<ITemplateResolverRegistry>();
        }

        /// <summary>
        /// Index action of this page
        /// </summary>
        /// <param name="currentPage">The current page.</param>
        /// <returns></returns>
        public override ActionResult Index(PageDataBase currentPage)
        {
            var renderSettings = ControllerContext.RouteData.Values["renderSettings"] as Dictionary<string, object>;

            var content = currentPage.As<PageDataBase>();

            if (renderSettings == null)
                return null;

            object tag;
            if (!renderSettings.TryGetValue("tag", out tag) || string.IsNullOrEmpty(tag?.ToString()))
            {
                return null;
            }

            var viewModel = _templateResolverModelFactory.CreateViewModel(tag.ToString(), content);
            var view = _templateResolverModelFactory.GetView(tag.ToString(), content);

            return PartialView(view, viewModel);
        }
    }
}