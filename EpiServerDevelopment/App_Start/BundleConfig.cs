using System.Web.Optimization;

namespace EpiServerDevelopment
{
    /// <summary>
    /// The BundleConfig is used to register bundles for CSS and JS 
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        /// Registers the bundles.
        /// </summary>
        /// <param name="bundles">The bundles.</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/css").Include(
                "~/Resources/css/owl.carousel.css",
                "~/Resources/css/bootstrap.min.css",
                "~/Resources/css/font-awesome.min.css",
                "~/Resources/css/style.css",
                "~/Resources/css/ionicons.min.css",
                "~/Resources/css/animate.css",
                "~/Resources/css/responsive.css")
            );

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Resources/js/vendor/modernizr-2.6.2.min.js",
                "~/Resources/js/vendor/jquery-1.10.2.min.js",
                "~/Resources/js/bootstrap.min.js",
                "~/Resources/js/owl.carousel.min.js",
                "~/Resources/js/plugins.js",
                "~/Resources/js/waypoints.min.js",
                "~/Resources/js/js/main.js")
            );

            bundles.Add(new ScriptBundle("~/bundles/editmode-css").Include(
                "~/Resources/css/editmode.css"
                ));
        }
    }
}