using EPiServer;

namespace EpiServerDevelopment.Features.Images
{
    /// <summary>
    /// The interface IImageSizeRetriever defines the functionality to set the size of an image which have been changed or uploaded
    /// </summary>
    public interface IImageSizeRetriever
    {
        /// <summary>
        /// Called when saving an image.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The <see cref="ContentEventArgs"/> instance containing the event data.</param>
        void OnSavingImage(object sender, ContentEventArgs args);

        /// <summary>
        /// Called when creating an image.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The <see cref="ContentEventArgs"/> instance containing the event data.</param>
        void OnCreatingImage(object sender, ContentEventArgs args);
    }
}