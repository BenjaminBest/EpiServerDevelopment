using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.Core.Internal;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace EpiServerDevelopment.Features.DisplayOptions
{

    /// <summary>
    /// The InitializationModule registers the available display options
    /// </summary>
    /// <seealso cref="IInitializableModule" />
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class InitializationModule : IInitializableModule
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
            var options = ServiceLocator.Current.GetInstance<EPiServer.Web.DisplayOptions>();

            //Remove existent options
            foreach (var id in options.Select(o => o.Id).ToList())
            {
                options.Remove(id);
            }

            options
                .Add("LeftTextTeaser", "Left Text Teaser", "LeftTextTeaser")
                .Add("RightTextWithImageTeaser", "Right Text with Image Teaser", "RightTextWithImageTeaser");
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