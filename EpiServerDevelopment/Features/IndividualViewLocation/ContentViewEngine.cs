using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using System.Web.Mvc;

namespace EpiServerDevelopment.Features.IndividualViewLocation
{
    /// <summary>
    /// The class ContentViewEngine is used to change the default location of where razor searches for views
    /// </summary>
    /// <seealso cref="RazorViewEngine" />
    /// <remarks>http://marisks.net/2017/02/03/razor-view-engine-for-feature-folders/</remarks>
    public class ContentViewEngine : RazorViewEngine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentViewEngine"/> class.
        /// </summary>
        public ContentViewEngine()
        {
            ViewLocationFormats = GetFeatureFolderLocation();
            MasterLocationFormats = GetFeatureFolderLocation();
            PartialViewLocationFormats = GetFeatureFolderLocation();
            FileExtensions = new[] { "cshtml" };
        }

        /// <summary>
        /// Gets the feature folder location.
        /// </summary>
        /// <returns></returns>
        private static string[] GetFeatureFolderLocation()
        {
            //Default
            return new[]
                {
                    "~/Features/{0}.cshtml",
                    "~/Features/{1}/{0}.cshtml",
                    "~/Features/{1}/{1}.cshtml",
                    "~/Features/{1}/Views/{0}.cshtml",
                    "~/Features/{1}/Views/{1}.cshtml",
                    "~/Features/Shared/Views/{0}.cshtml"
                }
                //All
                .Union(AllFolders())
                .ToArray();
        }

        /// <summary>
        /// Scanns all available folders.
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<string> AllFolders()
        {
            var rootFolder = HostingEnvironment.MapPath("~/Features/");
            if (rootFolder == null)
            {
                return Enumerable.Empty<string>();
            }
            var subFolders = Directory.GetDirectories(rootFolder).Select(p => new DirectoryInfo(p).Name);
            return subFolders
                .SelectMany(
                    dir => new[]
                    {   
                        // No controller, page type = view name
                        $"~/Features/{dir}/{{0}}.cshtml",

                        // With MVC controller, doesn't work with content types,
                        // controller name = view name
                        $"~/Features/{dir}/{{1}}.cshtml",

                        // With any controller, controller name + action name = view name
                        $"~/Features/{dir}/{{1}}{{0}}.cshtml",

                        // Sub-feature, controller name = sub-folder name, action = view name
                        $"~/Features/{dir}/{{1}}/{{0}}.cshtml",

                        // Sub-feature, controller name = sub-folder name,
                        // controller name + action name = view name
                        $"~/Features/{dir}/{{1}}/{{1}}{{0}}.cshtml"
                    });
        }
    }
}