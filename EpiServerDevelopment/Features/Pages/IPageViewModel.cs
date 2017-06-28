namespace EpiServerDevelopment.Features.Pages
{
    /// <summary>
    /// Defines common characteristics for view models for pages, including properties used by layout files.
    /// </summary>
    /// <remarks>
    /// Views which should handle several page types (T) can use this interface as model type rather than the
    /// concrete PageViewModel class, utilizing the that this interface is covariant.
    /// </remarks>
    public interface IPageViewModel<out T> where T : PageDataBase
    {
        /// <summary>
        /// Gets the current page.
        /// </summary>
        /// <value>
        /// The current page.
        /// </value>
        T CurrentPage { get; }
    }
}