using System.Collections.Generic;
using System.Diagnostics;
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
        /// <remarks>
        /// {0} - action name (also content type name in Episerver)
        /// {1} - controller name.
        /// </remarks>
        /// <returns></returns>
        private static string[] GetFeatureFolderLocation()
        {
            //Default
            var locations = new[]
                {
                    //Views in the folder which matches controller name and the view matches action name.
                    "~/Features/{1}/{0}.cshtml",
                    //Views in the folder which matches controller name and the view matches controller name.
                    "~/Features/{1}/{1}.cshtml"
                }
                //All
                .Union(AllFolders())
                .ToArray();


            foreach (var loc in locations)
            {
                Debug.WriteLine(loc);
            }

            return locations;
        }

        /// <summary>Creates a partial view using the specified controller context and partial path.</summary>
        /// <returns>The partial view.</returns>
        /// <param name="controllerContext">The controller context.</param>
        /// <param name="partialPath">The path to the partial view.</param>
        protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        {
            Debug.WriteLine($"Searching for controller [1] {controllerContext.Controller} with partialPath {partialPath}");

            return base.CreatePartialView(controllerContext, partialPath);
        }

        /// <summary>Creates a view by using the specified controller context and the paths of the view and master view.</summary>
        /// <returns>The view.</returns>
        /// <param name="controllerContext">The controller context.</param>
        /// <param name="viewPath">The path to the view.</param>
        /// <param name="masterPath">The path to the master view.</param>
        protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        {
            Debug.WriteLine($"Searching for controller [1] {controllerContext.Controller} with viewPath {viewPath} and masterPath {masterPath} ");

            return base.CreateView(controllerContext, viewPath, masterPath);
        }

        /// <summary>
        /// Scanns all available folders.
        /// </summary>
        /// <remarks>
        /// To be able to add feature folders with any name, a view engine scan all folders in the Features folder
        /// and register view location format for each of it. It includes all possible view location formats needed for a single folder.
        /// </remarks>
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
                        $"~/Features/{dir}/{{1}}_{{0}}.cshtml"
                    });
        }
    }
}