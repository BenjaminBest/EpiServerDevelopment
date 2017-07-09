using EPiServer.Core;
using EPiServer.Framework.Serialization;
using EPiServer.Framework.Serialization.Internal;
using EPiServer.ServiceLocation;

namespace EpiServerDevelopment.Features.PropertyList
{
    /// <summary>
    /// The class PropertyListBase defines a base class for properties that uses the PropertyList type.
    /// </summary>
    public class PropertyListBase<TItem> : PropertyList<TItem>
    {
        /// <summary>
        /// The object serializer factory
        /// </summary>
        private Injected<ObjectSerializerFactory> ObjectSerializerFactory { get; set; }

        /// <summary>
        /// The object serializer
        /// </summary>
        private readonly IObjectSerializer _objectSerializer;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyListBase{TItem}"/> class.
        /// </summary>
        public PropertyListBase()
        {
            _objectSerializer = ObjectSerializerFactory.Service.GetSerializer("application/json");
        }

        /// <summary>
        /// Creates a new instance of <see cref="T:EPiServer.Core.PropertyData" /> with the given value, ie reversed ToString().
        /// </summary>
        /// <param name="value">The string value to parse.</param>
        /// <returns>A new instance of <see cref="T:EPiServer.Core.PropertyData" /> with the given value.</returns>
        public override PropertyData ParseToObject(string value)
        {
            ParseToSelf(value);

            return this;
        }

        /// <summary>
        /// Parses a string into an item of the list item type <typeparamref name="T" />. String is checked for null or empty values before called.
        /// </summary>
        /// <param name="value">The string value that should be parsed.</param>
        /// <returns>
        /// </returns>
        /// <remarks>
        /// This method should mirror the output of the ToString method of the type. Used for default value handling.
        /// </remarks>
        protected override TItem ParseItem(string value)
        {
            return _objectSerializer.Deserialize<TItem>(value);
        }
    }
}