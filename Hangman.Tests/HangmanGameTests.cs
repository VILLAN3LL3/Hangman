using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace Hangman.Tests
{
    [TestFixture]
    public class HangmanGameTests
    {
        private HangmanGame _hangmanGame;

        [OneTimeSetUp]
        public void SetUp() => _hangmanGame = CreateHangmanGame();

        private HangmanGame CreateHangmanGame() => new HangmanGame("Developer");

        private static IEnumerable<TestCaseData> s_testData
        {
            get
            {
                yield return new TestCaseData('u', "---------");
                yield return new TestCaseData('e', "-e-e---e-");
                yield return new TestCaseData('n', "-e-e---e-");
                yield return new TestCaseData('o', "-e-e-o-e-");
                yield return new TestCaseData('r', "-e-e-o-er");
                yield return new TestCaseData('a', "-e-e-o-er");
                yield return new TestCaseData('d', "De-e-o-er");
                yield return new TestCaseData('l', "De-elo-er");
                yield return new TestCaseData('p', "De-eloper");
                yield return new TestCaseData('v', "Developer");
            }
        }

        [TestCaseSource(nameof(s_testData))]
        public void Should_GuessLetter(char guessedLetter, string expectedResult)
        {
            string result = _hangmanGame.GuessLetter(
                guessedLetter);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
