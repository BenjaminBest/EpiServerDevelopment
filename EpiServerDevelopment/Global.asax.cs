using System.Web.Mvc;
using System.Web.Optimization;
using EpiServerDevelopment.Features.IndividualViewLocation;

namespace EpiServerDevelopment
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //Register individual view locations
            ViewEngineRegistration.Register(ViewEngines.Engines);

            //Register bundles
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}