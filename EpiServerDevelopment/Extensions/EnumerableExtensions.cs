using System.Collections.Generic;
using System.Linq;

namespace EpiServerDevelopment.Extensions
{
    /// <summary>
    /// The class EnumerableExtensions provides extension methods for IEnumerable
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Ensurestha the given IEnumerable is not <c>null</c>.
        /// </summary>
        /// <typeparam name="TType">The type of the type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns>At least an empty list, not <c>null</c></returns>
        public static IEnumerable<TType> EnsureNotNull<TType>(this IEnumerable<TType> enumerable)
        {
            return enumerable ?? Enumerable.Empty<TType>();
        }
    }
}