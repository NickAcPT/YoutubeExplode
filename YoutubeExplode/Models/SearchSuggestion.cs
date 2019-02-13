using JetBrains.Annotations;

namespace YoutubeExplode.Models
{
    /// <summary>
    /// Information about a YouTube search suggestion
    /// </summary>
    public class SearchSuggestion
    {
        /// <summary>
        /// Initializes an instance of <see cref="Value"/>.
        /// </summary>
        /// <param name="value"></param>
        public SearchSuggestion([NotNull] string value)
        {
            Value = value;
        }

        /// <summary>
        /// The text of this suggestion
        /// </summary>
        [NotNull]
        public string Value { get; set; }
    }
}