using System.Drawing;
using EPiServer.Core;
using EpiServerDevelopment.Extensions;
using EpiServerDevelopment.Features.Images;
using EpiServerDevelopment.Features.Pages;
using EpiServerDevelopment.Features.Teasers;
using EpiServerDevelopment.Features.TemplateResolver;

namespace EpiServerDevelopment.Features.MetaNavigation
{
    /// <summary>
    /// The class DefaultTemplateResolver provides the mapping for the most commen case
    /// </summary>
    /// <seealso cref="ITemplateResolver" />
    public class MetaNavigationLinkTemplateResolver : BaseTemplateResolver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTemplateResolver"/> class.
        /// </summary>
        public MetaNavigationLinkTemplateResolver()
            : base("Default", "MetaNavigationLink", new Size(0, 0), typeof(ContentAreaItem), typeof(DefaultTemplateViewModel))
        {
        }

        /// <summary>
        /// Gets the view model based on the given <paramref name="content"/>
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        public override object GetViewModel(object content)
        {
            content = content.As<ContentAreaItem>().IsNotNull(i => i.GetContent());

            var source = content.As<PageDataBase>();

            if (source == null)
                return null;

            var model = new DefaultTemplateViewModel
            {
                Title = source.Title,
                SubTitle = source.SubTitle,
                Description = source.Description,
                ButtonCaption = source.ButtonCaption,
                Image = source.Images.AsImages().OfSize(ImageMinDimensions.Width, ImageMinDimensions.Height),
                Link = source.ContentLink
            };

            return model;
        }
    }
}