namespace EpiServerDevelopment.Features.TemplateResolver
{
    /// <summary>
    /// The interface ITemplateResolverRegistry defines a registry to get the correct view for a given tag or type
    /// </summary>
    public interface ITemplateResolverRegistry
    {
        /// <summary>
        /// Creates the view model.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        object CreateViewModel<TContent>(string tag, TContent content) where TContent : class;

        /// <summary>
        /// Gets the view for the given <paramref name="tag" />
        /// </summary>
        /// <typeparam name="TContent">The type of the content.</typeparam>
        /// <param name="tag">The tag.</param>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        string GetView<TContent>(string tag, TContent content) where TContent : class;
    }
}