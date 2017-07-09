using EPiServer.PlugIn;
using EpiServerDevelopment.Features.PropertyList;

namespace EpiServerDevelopment.Features.IconListTeaser
{
    /// <summary>
    /// The IconListTeaserProperty is the backing type for the icon list property of the <seealso cref="IconListTeaserBlock"/>
    /// </summary>
    /// <seealso cref="PropertyList.PropertyListBase{IconTeaserItem}" />
    [PropertyDefinitionTypePlugIn]
    public class IconListTeaserProperty : PropertyListBase<IconTeaserItem>
    {
    }
}