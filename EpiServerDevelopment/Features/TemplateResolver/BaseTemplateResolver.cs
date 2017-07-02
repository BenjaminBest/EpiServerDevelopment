using System;
using System.Drawing;
using EpiServerDevelopment.Features.Teasers;

namespace EpiServerDevelopment.Features.TemplateResolver
{
    /// <summary>
    /// The class BaseTemplateResolver provides as a base class common functionality used in inherited resolvers
    /// </summary>
    /// <seealso cref="ITemplateResolver" />
    public abstract class BaseTemplateResolver : ITemplateResolver
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
        /// Gets the display name of the view in the display options menu.
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
        /// Gets or sets the image minimum dimensions.
        /// </summary>
        /// <value>
        /// The image minimum dimensions.
        /// </value>
        public Size ImageMinDimensions { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTemplateResolver" /> class.
        /// </summary>
        /// <param name="displayOptionsName">Display name of the options.</param>
        /// <param name="renderTag">The render tag.</param>
        /// <param name="imageMinDimensions">The image minimum dimensions.</param>
        /// <param name="supportedSourceContentType">Type of the supported source content.</param>
        /// <param name="supportedViewModel">The supported view model.</param>
        protected BaseTemplateResolver(
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
        public abstract object GetViewModel(object content);
    }
}