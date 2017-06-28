using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using StructureMap;

namespace EpiServerDevelopment.Features.GlobalLayout
{
    /// <summary>
    /// The StructureMapDependencyResolver is used for service localization with structure map
    /// </summary>
    /// <seealso cref="IDependencyResolver" />
    public class StructureMapDependencyResolver : IDependencyResolver
    {
        /// <summary>
        /// The container
        /// </summary>
        readonly IContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="StructureMapDependencyResolver"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        public StructureMapDependencyResolver(IContainer container)
        {
            _container = container;
        }

        /// <summary>
        /// Resolves singly registered services that support arbitrary object creation.
        /// </summary>
        /// <param name="serviceType">The type of the requested service or object.</param>
        /// <returns>
        /// The requested service or object.
        /// </returns>
        public object GetService(Type serviceType)
        {
            if (serviceType.IsInterface || serviceType.IsAbstract)
            {
                return GetInterfaceService(serviceType);
            }
            return GetConcreteService(serviceType);
        }

        /// <summary>
        /// Gets the concrete service.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <returns></returns>
        private object GetConcreteService(Type serviceType)
        {
            try
            {
                return _container.GetInstance(serviceType);
            }
            catch (StructureMapException)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the interface service.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <returns></returns>
        private object GetInterfaceService(Type serviceType)
        {
            return _container.TryGetInstance(serviceType);
        }

        /// <summary>
        /// Resolves multiply registered services.
        /// </summary>
        /// <param name="serviceType">The type of the requested services.</param>
        /// <returns>
        /// The requested services.
        /// </returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.GetAllInstances(serviceType).Cast<object>();
        }
    }
}