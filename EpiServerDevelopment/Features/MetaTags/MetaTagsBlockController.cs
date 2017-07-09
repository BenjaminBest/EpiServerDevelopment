using System;
using System.Linq;
using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EpiServerDevelopment.Features.Pages;

namespace EpiServerDevelopment.Features.MetaTags
{
    /// <summary>
    /// The MetaTagsBlockController
    /// </summary>
    /// <seealso cref="BlockController{TBlockData}" />
    public class MetaTagsBlockController : BlockController<MetaTagsBlock>
    {
        /// <summary>
        /// The page hierarchy resolver
        /// </summary>
        private readonly IPageHierarchyResolver _pageHierarchyResolver;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaTagsBlockController"/> class.
        /// </summary>
        /// <param name="pageHierarchyResolver">The page hierarchy resolver.</param>
        public MetaTagsBlockController(IPageHierarchyResolver pageHierarchyResolver)
        {
            _pageHierarchyResolver = pageHierarchyResolver;
        }

        /// <summary>
        /// Index action of this block
        /// </summary>
        /// <param name="currentBlock">The current block.</param>
        /// <returns></returns>
        public override ActionResult Index(MetaTagsBlock currentBlock)
        {
            var model = new MetaTagsViewModel
            {
                Description = currentBlock.Description,
                Viewport = currentBlock.Viewport,
                Keywords = string.Join(", ", currentBlock.Keywords),
                Date = currentBlock.Date.HasValue && currentBlock.Date != DateTime.MinValue ? currentBlock.Date.Value.ToString("yyyy-MM-dd") : string.Empty,
                Author = currentBlock.Author
            };

            //Set defaults if values are not set
            SetDefaultValues(model);

            return PartialView(model);
        }

        /// <summary>
        /// Sets the defaults values for tags which are empty or adds further information.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>The viewmodel.</returns>
        private void SetDefaultValues(MetaTagsViewModel model)
        {
            if (string.IsNullOrEmpty(model.Viewport))
                model.Viewport = "width=device-width, initial-scale=1";

            var currentPage = _pageHierarchyResolver.GetCurrentPage<PageDataBase>();

            if (string.IsNullOrEmpty(model.Description))
                model.Description = currentPage.SubTitle;

            if (string.IsNullOrEmpty(model.Keywords))
                model.Keywords = currentPage.Category != null ? string.Join(", ", currentPage.Category.Select(c => c.ToString())) : string.Empty;

            if (string.IsNullOrEmpty(model.Date))
                model.Date = currentPage.Changed.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(model.Author))
                model.Author = currentPage.ChangedBy;
        }
    }
}
