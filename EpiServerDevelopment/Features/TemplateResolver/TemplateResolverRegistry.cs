﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Hosting;
using EpiServerDevelopment.Features.Teasers;
using WebGrease.Css.Extensions;

namespace EpiServerDevelopment.Features.TemplateResolver
{
    /// <summary>
    /// The class TemplateResolverRegistry provides the functionality to create a viewmodel for a given content type
    /// </summary>
    /// <seealso cref="ITemplateResolverRegistry" />
    public class TemplateResolverRegistry : ITemplateResolverRegistry
    {
        /// <summary>
        /// The template collector
        /// </summary>
        private readonly ITemplateCollector _templateCollector;

        /// <summary>
        /// The resolvers identified by tag
        /// </summary>
        private readonly List<TemplateResolverRegistryItem> _resolvers = new List<TemplateResolverRegistryItem>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResolverRegistry" /> class.
        /// </summary>
        /// <param name="tempplateCollector">The tempplate collector.</param>
        public TemplateResolverRegistry(ITemplateCollector tempplateCollector)
        {
            _templateCollector = tempplateCollector;
            RegisterViewMappers();
        }

        /// <summary>
        /// Creates the view model.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        public object CreateViewModel<TContent>(string tag, TContent content) where TContent : class
        {
            var item = GetItem<TContent>(tag);

            return item?.Resolver.GetViewModel(content);
        }

        /// <summary>
        /// Gets the view for the given <paramref name="tag" />
        /// </summary>
        /// <typeparam name="TContent">The type of the content.</typeparam>
        /// <param name="tag">The tag.</param>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        public string GetView<TContent>(string tag, TContent content) where TContent : class
        {
            var item = GetItem<TContent>(tag);

            return item == null ? string.Empty : item.RelativeViewPath;
        }

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <typeparam name="TContentType">The type of the content type.</typeparam>
        /// <param name="tag">The tag.</param>
        /// <returns></returns>
        private TemplateResolverRegistryItem GetItem<TContentType>(string tag) where TContentType : class
        {
            return _resolvers.FirstOrDefault(
                r => r.RenderTag.Equals(tag, StringComparison.InvariantCultureIgnoreCase) &&
                     r.Resolver.SupportedSourceContentType == typeof(TContentType));
        }

        /// <summary>
        /// Registers the view mappers.
        /// </summary>
        private void RegisterViewMappers()
        {
            //Get all available teasers
            var templates =
                _templateCollector.CollectTemplates($"{HostingEnvironment.ApplicationPhysicalPath}/Features").ToList();

            //Get all view resolvers
            var availableResolversTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => typeof(ITemplateResolver).IsAssignableFrom(t) && !t.IsAbstract && !t.IsInterface).ToList();

            foreach (var item in templates)
            {
                var availableResolvers = availableResolversTypes.Select(t => (ITemplateResolver)Activator.CreateInstance(t)).ToList();

                //Find directly matching resolvers
                var matchingResolvers = availableResolvers.Where(
                    r => r.RenderTag.Equals(item.ViewName, StringComparison.InvariantCultureIgnoreCase)
                         && r.SupportedViewModel == item.ViewModelType);

                //Find fallback resolvers which at least support viewmodel
                if (!matchingResolvers.Any())
                {
                    matchingResolvers = availableResolvers.Where(
                        r => r.SupportedViewModel == item.ViewModelType);

                    //Add default image dimensions; special resolvers do not need this
                    matchingResolvers.ForEach(r => r.ImageMinDimensions = DefaultImageDimensions.GetDimensionForTag(item.ViewName));
                }

                if (matchingResolvers.Any())
                {
                    //Add all resolvers, can be multiple because of different source types mapped to the tag and viewmodel
                    matchingResolvers.ForEach(r => _resolvers.Add(
                        new TemplateResolverRegistryItem(item.ViewName, r, item.RelativePath)));
                }
            }
        }
    }
}