using System.Web.Mvc;
using System.Web.Mvc.Html;
using EPiServer.ServiceLocation;

namespace EpiServerDevelopment.Features.TemplateResolver
{
    /// <summary>
    /// The class HtmlExtensions provides extension methods for the template system based on HtmlHelper
    /// </summary>
    public static class HtmlExtensions
    {
        /// <summary>
        /// Gets or sets the template registry.
        /// </summary>
        /// <value>
        /// The template registry.
        /// </value>
        private static Injected<ITemplateResolverRegistry> TemplateRegistry { get; set; }

        /// <summary>
        /// Renders the specified partial view, passing it a copy of the current <see cref="T:System.Web.Mvc.ViewDataDictionary" /> object, 
        /// but with the Model property set to the specified model.</summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="partialViewName">The name of the partial view.</param>
        /// <param name="model">The model.</param>
        public static void RenderPartialTemplate<TModelType>(this HtmlHelper htmlHelper, string partialViewName, TModelType model) where TModelType : class
        {
            var viewmodel = TemplateRegistry.Service.CreateViewModel(partialViewName, model);

            if (viewmodel != null)
                htmlHelper.RenderPartial(partialViewName, viewmodel);
        }
    }
}