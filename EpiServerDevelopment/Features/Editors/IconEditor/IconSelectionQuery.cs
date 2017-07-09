using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing;
using Newtonsoft.Json;

namespace EpiServerDevelopment.Features.Editors.IconEditor
{
    /// <summary>
    /// The IconSelectionQuery provides methods to get all icons from editor client side and queries in the list
    /// </summary>
    /// <seealso cref="ISelectionQuery" />
    [ServiceConfiguration(typeof(ISelectionQuery), Lifecycle = ServiceInstanceScope.Singleton)]
    public class IconSelectionQuery : ISelectionQuery
    {
        /// <summary>
        /// The icons
        /// </summary>
        private readonly IEnumerable<ISelectItem> _icons;

        /// <summary>
        /// Initializes a new instance of the <see cref="IconSelectionQuery"/> class.
        /// </summary>
        public IconSelectionQuery()
        {
            _icons = GetIcons();
        }

        /// <summary>
        /// Gets the icons.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<ISelectItem> GetIcons()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Features\Editors\IconEditor\Icons.json");

            if (!File.Exists(path))
                yield break;

            var json = File.ReadAllText(path);

            var icons = JsonConvert.DeserializeObject<IEnumerable<Icon>>(json);

            foreach (var icon in icons)
            {
                yield return new SelectItem()
                {
                    Text = icon.Name,
                    Value = icon.CssClass
                };
            }
        }

        /// <summary>
        /// Gets the item by value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public ISelectItem GetItemByValue(string value)
        {
            return _icons.FirstOrDefault(i => i.Value.Equals(value));
        }

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        public IEnumerable<ISelectItem> GetItems(string query)
        {
            var formattedQuery = query.ToLower();

            return _icons
                .Where(e => e.Text.ToLower().Contains(formattedQuery))
                .OrderBy(m => m.Text)
                .Take(10);
        }
    }
}