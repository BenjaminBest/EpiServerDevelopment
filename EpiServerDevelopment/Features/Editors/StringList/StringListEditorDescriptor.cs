using System;
using System.Collections.Generic;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace EpiServerDevelopment.Features.Editors.StringList
{
    /// <summary>
    /// The class StringListEditorDescriptor defines a descriptor for a string list which all components by the type, a UI hint and the DOJO editor
    /// </summary>
    /// <seealso cref="EditorDescriptor" />
    [EditorDescriptorRegistration(TargetType = typeof(IList<string>), UIHint = CustomUiHints.StringList)]
    public class StringListEditorDescriptor : EditorDescriptor
    {
        /// <summary>
        /// Modifies the metadata.
        /// </summary>
        /// <param name="metadata">The metadata.</param>
        /// <param name="attributes">The attributes.</param>
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            ClientEditingClass = "cms/editors/stringlist/Editor";
            //ClientEditingClass = "EpiServerDevelopment.editors.stringlist.StringListEditor";

            base.ModifyMetadata(metadata, attributes);
        }
    }
}