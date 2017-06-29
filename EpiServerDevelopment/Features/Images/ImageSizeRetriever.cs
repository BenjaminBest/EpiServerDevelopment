using System;
using EpiServerDevelopment.Extensions;
using EPiServer;

namespace EpiServerDevelopment.Features.Images
{
    /// <summary>
    /// The class ImageSizeRetriever provides the functionality to set the size of an image which have been changed or uploaded
    /// </summary>
    /// <seealso cref="IImageSizeRetriever" />
    public class ImageSizeRetriever : IImageSizeRetriever
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
            //    System.Drawing.Image image;
            //    using (var stream = content.BinaryData.OpenRead())
            //    {
            //        image = System.Drawing.Image.FromStream(stream, false);
            //        image.IsNotNull(i => content.SetSize(i.Width, i.Height));

            //        image.Dispose();
            //    }
            //}
            //catch (Exception e)
            //{
            //}
        }
    }
}