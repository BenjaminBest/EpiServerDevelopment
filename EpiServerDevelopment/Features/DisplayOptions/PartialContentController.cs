using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpiServerDevelopment.Extensions;
using EpiServerDevelopment.Features.Pages;
using EpiServerDevelopment.Features.Teasers;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.Web.Mvc;

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
        /// The view model factory
        /// </summary>
        private readonly ITeaserViewModelFactory _viewModelFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayOptionsPartialContentController"/> class.
        /// </summary>
        /// <param name="viewModelFactory">The view model factory.</param>
        public DisplayOptionsPartialContentController(ITeaserViewModelFactory viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }

        /// <summary>
        /// Index action of this page
        /// </summary>
        /// <param name="currentPage">The current page.</param>
        /// <returns></returns>
        public override ActionResult Index(PageDataBase currentPage)
        {
            var renderSettings = this.ControllerContext.RouteData.Values["renderSettings"] as Dictionary<string, object>;

            var content = currentPage.As<PageDataBase>();
            var viewModel = _viewModelFactory.CreateViewModel(content);

            const string defaultTemplate = "/Features/Teasers/LeftTextTeaser.cshtml";

            if (renderSettings == null)
                return PartialView(defaultTemplate, viewModel);

            object tag;
            if (!renderSettings.TryGetValue("tag", out tag) || string.IsNullOrEmpty(tag?.ToString()))
            {
                return PartialView(defaultTemplate, viewModel);
            }

            return PartialView($"/Features/Teasers/{tag}.cshtml", viewModel);
        }
    }
}