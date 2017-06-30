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
            using (var stream = content.BinaryData.OpenRead())
            {
                using (var image = System.Drawing.Image.FromStream(stream, false))
                {
                    if (!image.Height.ToString().Equals(content.Height) ||
                        !image.Width.ToString().Equals(content.Width))
                    {
                        content.SetSize(image.Width, image.Height);
                    }
                }
            }
        }
    }
}