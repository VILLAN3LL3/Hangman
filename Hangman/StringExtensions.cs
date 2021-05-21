using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    public static class StringExtensions
    {
        public static IEnumerable<int> AllIndexesOf(this string word, char searchedLetter)
        {
            char lowerLetter = char.ToLower(searchedLetter);
            return word
                .ToLowerInvariant()
                .Select((letter, index) => letter.Equals(lowerLetter) ? index : -1)
                .Where(index => index != -1);
        }
    }
}
