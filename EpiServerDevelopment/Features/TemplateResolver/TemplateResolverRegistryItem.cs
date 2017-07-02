namespace EpiServerDevelopment.Features.TemplateResolver
{
    /// <summary>
    /// The class TemplateResolverRegistryItem holds all information needed to find the view for a tag with a specific model
    /// </summary>
    public class TemplateResolverRegistryItem
    {
        /// <summary>
        /// Gets the resolver.
        /// </summary>
        /// <value>
        /// The resolver.
        /// </value>
        public ITemplateResolver Resolver { get; }

        /// <summary>
        /// Gets the relative view path.
        /// </summary>
        /// <value>
        /// The relative view path.
        /// </value>
        public string RelativeViewPath { get; }

        /// <summary>
        /// Gets the render tag.
        /// </summary>
        /// <value>
        /// The render tag.
        /// </value>
        public string RenderTag { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResolverRegistryItem" /> class.
        /// </summary>
        /// <param name="renderTag">The render tag.</param>
        /// <param name="resolver">The resolver.</param>
        /// <param name="relativeViewPath">The relative view path.</param>
        public TemplateResolverRegistryItem(string renderTag, ITemplateResolver resolver, string relativeViewPath)
        {
            Resolver = resolver;
            RelativeViewPath = relativeViewPath;
            RenderTag = renderTag;
        }
    }
}