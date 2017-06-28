using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace EpiServerDevelopment.Features.GlobalLayout
{
    /// <summary>
    /// The class InitializableModule is used during startup to do the initialization, like registering filters
    /// </summary>
    /// <seealso cref="IInitializableModule" />
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class InitializableModule : IInitializableModule
    {
        /// <summary>Initializes this instance.</summary>
        /// <param name="context">The context.</param>
        /// <remarks>
        /// Gets called as part of the EPiServer Framework initialization sequence. Note that it will be called
        /// only once per AppDomain, unless the method throws an exception. If an exception is thrown, the initialization
        /// method will be called repeadetly for each request reaching the site until the method succeeds.
        /// </remarks>
        public void Initialize(InitializationEngine context)
        {
            GlobalFilters.Filters.Add(ServiceLocator.Current.GetInstance<PageContextActionFilter>());
        }

        /// <summary>Resets the module into an uninitialized state.</summary>
        /// <param name="context">The context.</param>
        /// <remarks>
        ///   <para>
        ///       This method is usually not called when running under a web application since the web app may be shut down very
        ///       abruptly, but your module should still implement it properly since it will make integration and unit testing
        ///       much simpler.
        ///       </para>
        ///   <para>
        ///       Any work done by <see cref="M:EPiServer.Framework.IInitializableModule.Initialize(EPiServer.Framework.Initialization.InitializationEngine)" /> as well as any code executing on <see cref="E:EPiServer.Framework.Initialization.InitializationEngine.InitComplete" /> should be reversed.
        ///       </para>
        /// </remarks>
        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}