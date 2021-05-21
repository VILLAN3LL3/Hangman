namespace Hangman
{
    public class HangmanGame
    {
        private readonly char[] _resultWord;
        private char[] _guessedWord;

        public HangmanGame(string resultWord)
        {
            _resultWord = resultWord.ToCharArray();
            _guessedWord = new string('-', _resultWord.Length).ToCharArray();
        }

        public string GuessLetter(char letter)
        {
            foreach (int index in _resultWord.AllIndexesOf(letter))
            {
                _guessedWord[index] = _resultWord[index];
            }

            return new string(_guessedWord);
        }
    }
}
