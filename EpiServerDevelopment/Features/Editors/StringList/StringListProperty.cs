using EPiServer.PlugIn;
using EpiServerDevelopment.Features.Base;

namespace EpiServerDevelopment.Features.Editors.StringList
{
    /// <summary>
    /// The class StringListProperty is a backing type for IList of strings
    /// </summary>
    /// <seealso cref="string" />
    [PropertyDefinitionTypePlugIn]
    public class StringListProperty : PropertyListBase<string>
    {
    }
}