using System.Collections.Generic;

namespace EpiServerDevelopment.Features.TemplateResolver
{
    /// <summary>
    /// The interface ITemplateCollector searches for all views in a given folder and collects the view name and the viewmodel
    /// </summary>
    public interface ITemplateCollector
    {
        /// <summary>
        /// Collects all templates in the given <paramref name="path"/> recursivly
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>Template items</returns>
        IEnumerable<TemplateCollectorItem> CollectTemplates(string path);
    }
}