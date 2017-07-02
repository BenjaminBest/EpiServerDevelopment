using System;

namespace EpiServerDevelopment.Features.TemplateResolver
{
    /// <summary>
    /// The class TemplateCollectorItem holds the information about one found view/template
    /// </summary>
    public class TemplateCollectorItem
    {
        /// <summary>
        /// Gets the relative path.
        /// </summary>
        /// <value>
        /// The relative path.
        /// </value>
        public string RelativePath { get; }

        /// <summary>
        /// Gets the type of the view model.
        /// </summary>
        /// <value>
        /// The type of the view model.
        /// </value>
        public Type ViewModelType { get; }

        /// <summary>
        /// Gets the name of the view without filetype
        /// </summary>
        /// <value>
        /// The name of the view without file type
        /// </value>
        public string ViewName { get; }


        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateCollectorItem"/> class.
        /// </summary>
        /// <param name="relativePath">The relative path.</param>
        /// <param name="viewModelType">Type of the view model.</param>
        /// <param name="viewName">Name of the view.</param>
        public TemplateCollectorItem(string relativePath, Type viewModelType, string viewName)
        {
            RelativePath = relativePath;
            ViewModelType = viewModelType;
            ViewName = viewName;
        }
    }
}