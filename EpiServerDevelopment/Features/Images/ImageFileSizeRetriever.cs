using System;
using EpiServerDevelopment.Extensions;
using EPiServer;

namespace EpiServerDevelopment.Features.Images
{
    /// <summary>
    /// The class IImageFileSizeRetriever provides the functionality to set the filesize of an image which have been changed or uploaded
    /// </summary>
    /// <seealso cref="IImageSizeRetriever" />
    public class ImageFileSizeRetriever : IImageFileSizeRetriever
    {
        /// <summary>
        /// Called when saving an image.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The <see cref="ContentEventArgs"/> instance containing the event data.</param>
        public void OnSavingImage(object sender, ContentEventArgs args)
        {
            args.Content.As<Image>().IsNotNull(SetSize);
        }

        /// <summary>
        /// Called when creating an image.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The <see cref="ContentEventArgs"/> instance containing the event data.</param>
        public void OnCreatingImage(object sender, ContentEventArgs args)
        {
            args.Content.As<Image>().IsNotNull(SetSize);
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="content">The content.</param>
        private static void SetSize(Image content)
        {
            //TODO: Fix StackOverFlowException
            //try
            //{
            //    using (var stream = content.BinaryData.OpenRead())
            //    {
            //        stream.IsNotNull(i => content.SetFileSize(i.Length));
            //    }
            //}
            //catch (Exception e)
            //{
            //}
        }
    }
}