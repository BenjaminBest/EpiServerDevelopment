using System;

namespace EpiServerDevelopment.Features.TemplateResolver
{
    /// <summary>
    /// The interface ITeaserViewResolver defines a resolver which hold the information what viewmodel the view needs, which tag is assigned, how the view should appier
    /// in the display options menu and the mapping between a source content type and the viewmodel.
    /// </summary>
    public interface ITemplateResolver
    {
        /// <summary>
        /// Gets the type of the supported source content.
        /// </summary>
        /// <value>
        /// The type of the supported source content.
        /// </value>
        Type SupportedSourceContentType { get; }

        /// <summary>
        /// Gets the supported view model.
        /// </summary>
        /// <value>
        /// The supported view model.
        /// </value>
        Type SupportedViewModel { get; }

        /// <summary>
        /// Sets the display name of the view in the display options menu.
        /// </summary>
        /// <value>
        /// The name name of the view in the display options menu.
        /// </value>
        string DisplayOptionsName { get; }

        /// <summary>
        /// Gets the render tag.
        /// </summary>
        /// <value>
        /// The render tag.
        /// </value>
        string RenderTag { get; }

        /// <summary>
        /// Gets the view model based on the given <paramref name="content"/>
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        object GetViewModel(object content);
    }
}