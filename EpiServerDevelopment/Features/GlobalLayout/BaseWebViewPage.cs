using System;
using System.Web.Mvc;
using EPiServer.ServiceLocation;

namespace EpiServerDevelopment.Features.GlobalLayout
{
    /// <summary>
    /// The class BaseWebViewPage extens the webviewpage with global layout settings and makes them available in views
    /// </summary>
    /// <seealso cref="WebViewPage" />
    public class BaseWebViewPage : WebViewPage
    {
        /// <summary>
        /// Gets or sets the layout model.
        /// </summary>
        /// <value>
        /// The layout model.
        /// </value>
        private Injected<LayoutModel> LayoutModel { get; set; }

        /// <summary>
        /// Gets the page layout.
        /// </summary>
        /// <value>
        /// The page layout.
        /// </value>
        public LayoutModel PageLayout => LayoutModel.Service;

        /// <summary>
        /// Executes this instance.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void Execute()
        {
        }
    }

    /// <summary>
    /// The class BaseWebViewPage extens the webviewpage with global layout settings and makes them available in views
    /// </summary>
    /// <seealso cref="WebViewPage" />
    public class BaseWebViewPage<TModel> : WebViewPage<TModel>
    {
        /// <summary>
        /// Gets or sets the layout model.
        /// </summary>
        /// <value>
        /// The layout model.
        /// </value>
        private Injected<LayoutModel> LayoutModel { get; set; }

        /// <summary>
        /// Gets the page layout.
        /// </summary>
        /// <value>
        /// The page layout.
        /// </value>
        public LayoutModel PageLayout => LayoutModel.Service;

        /// <summary>
        /// Executes this instance.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void Execute()
        {
        }
    }


}