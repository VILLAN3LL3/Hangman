using System.Text;

namespace Hangman
{
    public class HangmanGame
    {
        private readonly string _resultWord;
        private string _guessedWord;

        public HangmanGame(string resultWord)
        {
            _resultWord = resultWord;
            _guessedWord = new string('-', _resultWord.Length);
        }

        public string GuessLetter(char letter)
        {
            var stringBuilder = new StringBuilder(_guessedWord);

            foreach (int index in _resultWord.AllIndexesOf(letter))
            {
                stringBuilder[index] = _resultWord[index];
            }

            _guessedWord = stringBuilder.ToString();


            return _guessedWord;
        }
    }
}
