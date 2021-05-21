using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    public static class StringExtensions
    {
        public static IEnumerable<int> AllIndexesOf(this char[] wordArray, char searchedLetter)
        {
            string searchedLetterString = searchedLetter.ToString();

            return Enumerable.Range(0, wordArray.Length)
                .Where(i => wordArray[i].ToString().Equals(searchedLetterString, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
