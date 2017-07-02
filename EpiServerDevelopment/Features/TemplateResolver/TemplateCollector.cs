using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Compilation;
using System.Web.Hosting;

namespace EpiServerDevelopment.Features.TemplateResolver
{
    /// <summary>
    /// The class TemplateCollector searches for all views in a given folder and collects the view name and the viewmodel
    /// </summary>
    public class TemplateCollector : ITemplateCollector
    {
        /// <summary>
        /// Collects all templates in the given <paramref name="path"/> recursivly
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>Template items</returns>
        public IEnumerable<TemplateCollectorItem> CollectTemplates(string path)
        {
            var result = new List<TemplateCollectorItem>();

            var files = Directory.GetFiles(path, "*.cshtml", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                var relativePath = file.Replace(HostingEnvironment.ApplicationPhysicalPath, string.Empty);

                var type = BuildManager.GetCompiledType(relativePath);

                var model = type.GetProperties().FirstOrDefault(p => p.Name.Equals("Model", StringComparison.InvariantCultureIgnoreCase));

                if (model == null)
                    continue;

                result.Add(new TemplateCollectorItem(relativePath, model.PropertyType, new FileInfo(file).Name.Replace(".cshtml", string.Empty)));
            }

            return result;
        }
    }
}