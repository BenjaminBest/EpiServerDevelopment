using System.ComponentModel.DataAnnotations;
using EpiServerDevelopment.Extensions;
using EPiServer.Core;

namespace EpiServerDevelopment.Features.Validation
{
    /// <summary>
    /// The class ContentAreaMaxItemsAttribute validates if more that a given number of items are used in a content area. Then an error will be shown
    /// </summary>
    /// <seealso cref="ValidationAttribute" />
    public class ContentAreaMaxItemsAttribute : ValidationAttribute
    {
        /// <summary>
        /// The maximum items
        /// </summary>
        private readonly int _maximumItems;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentAreaMaxItemsAttribute"/> class.
        /// </summary>
        /// <param name="maximumItems">The maximum items.</param>
        public ContentAreaMaxItemsAttribute(int maximumItems)
        {
            _maximumItems = maximumItems;
        }

        /// <summary>
        /// Validates the specified value with respect to the current validation attribute.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <param name="validationContext">The context information about the validation operation.</param>
        /// <returns>An instance of the <see cref="T:System.ComponentModel.DataAnnotations.ValidationResult" /> class. </returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var result = base.IsValid(value, validationContext);

            if (!string.IsNullOrEmpty(result?.ErrorMessage))
            {
                result.ErrorMessage = $"{validationContext.DisplayName} {ErrorMessage}";
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified value of the object is valid.
        /// </summary>
        /// <param name="value">The value of the object to validate. </param>
        /// <returns>true if the specified value is valid; otherwise, false.</returns>
        public override bool IsValid(object value)
        {
            var contentArea = value.IsNotNull(v => v.As<ContentArea>());

            if (contentArea == null)
                throw new ValidationException("Use ContentAreaItemsMaxAttribute only for content areas");

            if (contentArea.Count > _maximumItems)
            {
                ErrorMessage = $"The Content Area is restricted to {_maximumItems} items";
                return false;
            }

            return true;
        }
    }
}