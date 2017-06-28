namespace EpiServerDevelopment.Features.Pages
{
    /// <summary>
    /// The PageViewModel is a 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="IPageViewModel{T}" />
    public class PageViewModel<T> : IPageViewModel<T> where T : PageDataBase
    {
        /// <summary>
        /// Gets the current page.
        /// </summary>
        /// <value>
        /// The current page.
        /// </value>
        public T CurrentPage { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageViewModel{T}"/> class.
        /// </summary>
        public PageViewModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageViewModel{T}"/> class.
        /// </summary>
        /// <param name="currentPage">The current page.</param>
        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }
    }

    /// <summary>
    /// The PageViewModel defines a page view model
    /// </summary>
    /// <seealso cref="IPageViewModel{T}" />
    public static class PageViewModel
    {
        /// <summary>
        /// Returns a viewmodel of type <typeparam name="T"/>.
        /// </summary>
        /// <remarks>
        /// Convenience method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
        /// </remarks>
        public static PageViewModel<T> Create<T>(T page) where T : PageDataBase
        {
            return new PageViewModel<T>(page);
        }
    }
}