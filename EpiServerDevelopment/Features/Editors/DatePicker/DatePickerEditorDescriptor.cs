using System;
using System.Collections.Generic;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace EpiServerDevelopment.Features.Editors.DatePicker
{
    /// <summary>
    /// The class DatePickerEditorDescriptor defines the descriptor for a date picker without time.
    /// </summary>
    /// <seealso cref="EditorDescriptor" />
    [EditorDescriptorRegistration(TargetType = typeof(DateTime))]
    [EditorDescriptorRegistration(TargetType = typeof(DateTime?))]
    public class DatePickerEditorDescriptor : EditorDescriptor
    {
        /// <summary>
        /// Modifies the metadata.
        /// </summary>
        /// <param name="metadata">The metadata.</param>
        /// <param name="attributes">The attributes.</param>
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            ClientEditingClass = "dijit/form/DateTextBox";

            base.ModifyMetadata(metadata, attributes);
        }
    }
}