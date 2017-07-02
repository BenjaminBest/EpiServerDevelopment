namespace EpiServerDevelopment.Features.Urls
{
    /// <summary>
    /// The class LinkTargetTypeExtensions provides extension methods for a target type
    /// </summary>
    public static class LinkTargetTypeExtensions
    {
        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public static string ToHtmlString(this LinkTargetType target)
        {
            switch (target)
            {
                case LinkTargetType.Blank:
                    return "_blank";
                case LinkTargetType.Self:
                    return "_self";
                default:
                    return "_self";
            }
        }
    }
}