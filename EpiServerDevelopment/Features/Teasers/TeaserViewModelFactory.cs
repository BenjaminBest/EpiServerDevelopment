using EpiServerDevelopment.Features.Images;
using EpiServerDevelopment.Features.Pages;

namespace EpiServerDevelopment.Features.Teasers
{
    /// <summary>
    /// The class TeaserViewModelFactory provides factory methods to create the videomodel for a teaser based on a content type
    /// </summary>
    /// <seealso cref="ITeaserViewModelFactory" />
    public class TeaserViewModelFactory : ITeaserViewModelFactory
    {
        /// <summary>
        /// Creates the view model.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        public object CreateViewModel(PageDataBase content)
        {
            var model = new DefaultTeaserViewModel
            {
                Title = content.Title,
                SubTitle = content.SubTitle,
                Description = content.Description,
                ButtonCaption = content.ButtonCaption,
                Image = content.Images.AsImages().OfSize(2560, 1564), //TODO: Configure per teaser
                Link = content.ContentLink
            };

            return model;
        }
    }
}