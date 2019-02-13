using System.Linq;
using Newtonsoft.Json.Linq;

namespace YoutubeExplode.Internal.Parsers
{
    internal partial class SearchSuggestionParser
    {
        private readonly JToken _root;

        public SearchSuggestionParser(JToken root)
        {
            _root = root;
        }

        public string[] GetSuggestionItems()
        {
            var values = _root.Children().ElementAtOrDefault(1);
            return values == null ? new string[0] : values.OfType<JArray>().Select(a => a.First).Select(t => t.Value<string>()).ToArray();
        }

    }

    internal partial class SearchSuggestionParser
    {
        public static SearchSuggestionParser Initialize(string raw)
        {
            var root = JToken.Parse(raw);
            return new SearchSuggestionParser(root);
        }
    }
}