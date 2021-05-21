using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    public class HangmanGameWithoutExtension
    {
        private readonly string _resultWord;
        private string _guessedWord;

        public HangmanGameWithoutExtension(string resultWord)
        {
            _resultWord = resultWord;
            _guessedWord = new string('-', _resultWord.Length);
        }

        public string GuessLetter(char letter)
        {
            var stringBuilder = new StringBuilder(_guessedWord);

            int minIndex = _resultWord.IndexOf(letter, StringComparison.InvariantCultureIgnoreCase);
            IList<int> indexList = new List<int>();

            while (minIndex != -1)
            {
                indexList.Add(minIndex);
                minIndex = _resultWord.IndexOf(letter, minIndex + 1);
            }

            foreach (int index in indexList)
            {
                stringBuilder[index] = _resultWord[index];
            }

            _guessedWord = stringBuilder.ToString();


            return _guessedWord;
        }
    }
}
