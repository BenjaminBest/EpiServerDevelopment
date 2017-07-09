using EPiServer.PlugIn;
using EpiServerDevelopment.Features.Base;

namespace EpiServerDevelopment.Features.IconListTeaser
{
    /// <summary>
    /// The IconListTeaserProperty is the backing type for the icon list property of the <seealso cref="IconListTeaserBlock"/>
    /// </summary>
    /// <seealso cref="PropertyListBase{TItem}" />
    [PropertyDefinitionTypePlugIn]
    public class IconListTeaserProperty : PropertyListBase<IconTeaserItem>
    {
    }
}