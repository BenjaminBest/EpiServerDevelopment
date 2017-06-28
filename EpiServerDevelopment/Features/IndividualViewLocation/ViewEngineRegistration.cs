using System.Linq;
using System.Web.Mvc;

namespace EpiServerDevelopment.Features.IndividualViewLocation
{
    /// <summary>
    /// The class ViewEngineRegistration is used to register the custom view engine
    /// </summary>
    public class ViewEngineRegistration
    {
        /// <summary>
        /// Registers the specified engines.
        /// </summary>
        /// <param name="engines">The engines.</param>
        public static void Register(ViewEngineCollection engines)
        {
            var razorViewEngine = engines
                .OfType<RazorViewEngine>()
                .FirstOrDefault();

            var contentViewEngine = new ContentViewEngine();

            if (null == razorViewEngine)
            {
                engines.Add(contentViewEngine);
            }
            else
            {
                var index = engines.IndexOf(razorViewEngine);
                engines.Insert(index, contentViewEngine);
            }
        }
    }
}