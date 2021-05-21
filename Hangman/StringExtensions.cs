using System;
using System.Collections.Generic;

namespace Hangman
{
    public static class StringExtensions
    {
        public static IEnumerable<int> AllIndexesOf(this string word, char searchedLetter)
        {
            int minIndex = word.IndexOf(searchedLetter, StringComparison.InvariantCultureIgnoreCase);
            while (minIndex != -1)
            {
                yield return minIndex;
                minIndex = word.IndexOf(searchedLetter, minIndex + 1);
            }
        }
    }
}
