using EPiServer.Core;

namespace EpiServerDevelopment.Features.Pages
{
    /// <summary>
    /// The interface IPageHierarchyResolver defines a resolver which resolves pages by type in the page tree
    /// </summary>
    public interface IPageHierarchyResolver
    {
        /// <summary>
        /// Gets the current or parent page if the page type is <typeparamref name="TPage"/>
        /// </summary>
        /// <typeparam name="TPage">The type of the page.</typeparam>
        /// <returns></returns>
        TPage GetCurrentOrParentPage<TPage>() where TPage : class;

        /// <summary>
        /// Gets the current page if the page type is <typeparamref name="TPage"/>
        /// </summary>
        /// <typeparam name="TPage">The type of the page.</typeparam>
        /// <returns></returns>
        TPage GetCurrentPage<TPage>() where TPage : class;

        /// <summary>
        /// Gets the parent page if the page type is <typeparamref name="TPage"/>
        /// </summary>
        /// <typeparam name="TPage">The type of the page.</typeparam>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        TPage GetParentPage<TPage>(PageData page) where TPage : class;
    }
}