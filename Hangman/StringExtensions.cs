using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    public static class StringExtensions
    {
        public static IEnumerable<int> AllIndexesOf(this char[] wordArray, char searchedLetter)
        {
            char lowerLetter = char.ToLowerInvariant(searchedLetter);

            return Enumerable.Range(0, wordArray.Length)
                .Where(i => char.ToLowerInvariant(wordArray[i]).Equals(lowerLetter));
        }
    }
}
