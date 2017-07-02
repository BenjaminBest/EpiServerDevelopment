using System;
using System.Drawing;
using EpiServerDevelopment.Extensions;
using EpiServerDevelopment.Features.Images;
using EpiServerDevelopment.Features.Pages;
using EpiServerDevelopment.Features.TemplateResolver;

namespace EpiServerDevelopment.Features.Teasers
{
    /// <summary>
    /// The class DefaultTemplateResolver provides the mapping for the most commen case
    /// </summary>
    /// <seealso cref="ITemplateResolver" />
    public class DefaultTemplateResolver : ITemplateResolver
    {
        /// <summary>
        /// Gets the type of the supported source content.
        /// </summary>
        /// <value>
        /// The type of the supported source content.
        /// </value>
        public Type SupportedSourceContentType { get; }

        /// <summary>
        /// Gets the supported view model.
        /// </summary>
        /// <value>
        /// The supported view model.
        /// </value>
        public Type SupportedViewModel { get; }

        /// <summary>
        /// Sets the display name of the view in the display options menu.
        /// </summary>
        /// <value>
        /// The name name of the view in the display options menu.
        /// </value>
        public string DisplayOptionsName { get; }

        /// <summary>
        /// Gets the render tag.
        /// </summary>
        /// <value>
        /// The render tag.
        /// </value>
        public string RenderTag { get; }

        /// <summary>
        /// Gets the image minimum dimensions.
        /// </summary>
        /// <value>
        /// The image minimum dimensions.
        /// </value>
        public Size ImageMinDimensions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTemplateResolver"/> class.
        /// </summary>
        public DefaultTemplateResolver()
            : this("Default", "Default", new Size(0, 0), typeof(PageDataBase), typeof(DefaultTemplateViewModel))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTemplateResolver" /> class.
        /// </summary>
        /// <param name="displayOptionsName">Display name of the options.</param>
        /// <param name="renderTag">The render tag.</param>
        /// <param name="imageMinDimensions">The image minimum dimensions.</param>
        /// <param name="supportedSourceContentType">Type of the supported source content.</param>
        /// <param name="supportedViewModel">The supported view model.</param>
        public DefaultTemplateResolver(
            string displayOptionsName,
            string renderTag,
            Size imageMinDimensions,
            Type supportedSourceContentType,
            Type supportedViewModel)
        {
            DisplayOptionsName = displayOptionsName;
            RenderTag = renderTag;
            ImageMinDimensions = imageMinDimensions;
            SupportedSourceContentType = supportedSourceContentType;
            SupportedViewModel = supportedViewModel;
        }

        /// <summary>
        /// Gets the view model based on the given <paramref name="content"/>
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        public virtual object GetViewModel(object content)
        {
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