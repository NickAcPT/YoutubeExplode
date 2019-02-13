using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoutubeExplode.Internal;
using YoutubeExplode.Models;

namespace YoutubeExplode
{
    public partial class YoutubeClient
    {
        /// <summary>
        /// Get search suggestions for a user query
        /// </summary>
        /// <param name="query">Query</param>
        /// <returns>Read-only list of suggestions for the inputted query</returns>
        public async Task<IReadOnlyList<SearchSuggestion>> GetSearchSuggestionsAsync(string query)
        {
            query.GuardNotNull(nameof(query));

            var parser = await GetSearchSuggestionParserForSearchAsync(query);

            var items = parser.GetSuggestionItems();

            return items.Select(item => new SearchSuggestion(item)).ToList();
        }
    }
}