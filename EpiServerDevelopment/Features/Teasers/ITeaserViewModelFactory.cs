using EpiServerDevelopment.Features.Pages;

namespace EpiServerDevelopment.Features.Teasers
{
    /// <summary>
    /// The interface ITeaserViewModelFactory defines a factory to create the videomodel for a teaser based on a content type
    /// </summary>
    public interface ITeaserViewModelFactory
    {
        /// <summary>
        /// Creates the view model.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        object CreateViewModel(PageDataBase content);
    }
}