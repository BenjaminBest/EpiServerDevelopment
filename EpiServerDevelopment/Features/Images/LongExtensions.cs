using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiServerDevelopment.Features.Images
{
    /// <summary>
    /// The class LongExtensions provides extension methods for long
    /// </summary>
    public static class Formatter
    {
        /// <summary>
        /// The sizes formats
        /// </summary>
        private static readonly string[] Sizes =
        {
            "B",
            "KB",
            "MB",
            "GB"
        };

        /// <summary>
        /// Formats the given <paramref name="fileSize"/> human readable
        /// </summary>
        /// <param name="fileSize">Size of the file.</param>
        /// <returns>Formatted filesize</returns>
        public static string FormatAsFileSize(long fileSize)
        {
            var index = 0;

            while (fileSize >= 1024 && index < Sizes.Length)
            {
                index++;
                fileSize /= 1024;
            }

            return string.Format($"{fileSize} {Sizes[index]}");
        }
    }
}