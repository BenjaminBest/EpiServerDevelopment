using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;

namespace EpiServerDevelopment.Features.IconListTeaser
{
    [ContentType(DisplayName = "IconListTeaserBlock", GUID = "FAF6F079-F6B7-418E-8DD2-A78F04C789E4",
        Description = "The icon list teaser shows a list of icons with text and headline")]
    public class IconListTeaserBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Headline",
            Description = "The headline of the whole teaser",
            GroupName = SystemTabNames.Content)]
        public virtual string Headline { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Description",
            Description = "The description below the headline",
            GroupName = SystemTabNames.Content)]
        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Icon List",
            Description = "The icon list contains the icons",
            GroupName = SystemTabNames.Content)]
        [EditorDescriptor(EditorDescriptorType = typeof(CollectionEditorDescriptor<IconTeaserItem>))]
        public virtual IEnumerable<IconTeaserItem> IconList { get; set; }
    }
}