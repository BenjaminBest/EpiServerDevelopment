using System.ComponentModel.DataAnnotations;
using EpiServerDevelopment.Extensions;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAccess;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EpiServerDevelopment.Features.Images
{
    [ContentType(DisplayName = "Image", GUID = "79eb5f83-a4a9-49c5-b762-bc73f59805b4", Description = "Image")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,png,gif,bmp,ico,jpe")]
    public class Image : ImageData
    {
        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Description",
            Description = "The description of an image",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Description { get; set; }

        [Editable(false)]
        [Display(
            Name = "Width",
            Description = "The width of an image in pixel",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual string Width { get; set; }

        [Editable(false)]
        [Display(
            Name = "Height",
            Description = "The height of an image in pixel",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual string Height { get; set; }

        [Editable(false)]
        [Display(
            Name = "FileSize",
            Description = "The filesize of an image in bytes",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual string FileSize { get; set; }

        /// <summary>
        /// Sets the size in pixel
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void SetSize(int width, int height)
        {
            var image = CreateWritableClone().As<Image>();

            image.Height = height.ToString();
            image.Width = width.ToString();

            DataFactory.Instance.Save(image, SaveAction.Default);
        }

        /// <summary>
        /// Sets the filesize in bytes
        /// </summary>
        /// <param name="fileSize">Size of the file.</param>
        public void SetFileSize(long fileSize)
        {
            var image = CreateWritableClone().As<Image>();

            image.FileSize = Formatter.FormatAsFileSize(fileSize);

            DataFactory.Instance.Save(image, SaveAction.Default);
        }
    }
}