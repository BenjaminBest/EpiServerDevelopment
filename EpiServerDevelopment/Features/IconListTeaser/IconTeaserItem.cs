using System.ComponentModel.DataAnnotations;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EpiServerDevelopment.Features.Editors.IconEditor;

namespace EpiServerDevelopment.Features.IconListTeaser
{
    /// <summary>
    /// The IconTeaserItem defines one teaser item which is used in a list to show a icon teaser list.
    /// </summary>
    public class IconTeaserItem
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [CultureSpecific]
        [Display(Name = "Name", Description = "The name of the item")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [CultureSpecific]
        [Display(Name = "Text", Description = "The text of the item")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        /// <value>
        /// The icon.
        /// </value>
        [Display(Name = "Icon", Description = "The icon of the item")]
        [AutoSuggestSelection(typeof(IconSelectionQuery), AllowCustomValues = true)]
        public string Icon { get; set; }
    }
}