using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace Hangman.Tests
{
    [TestFixture]
    public class HangmanGameHumptyDumptyTests
    {
        private HangmanGame _hangmanGame;

        [OneTimeSetUp]
        public void SetUp() => _hangmanGame = CreateHangmanGame();

        private HangmanGame CreateHangmanGame() => new HangmanGame("HumptyDumpty");

        private static IEnumerable<TestCaseData> s_testData
        {
            get
            {
                yield return new TestCaseData('r', "------------");
                yield return new TestCaseData('m', "--m-----m---");
                yield return new TestCaseData('u', "-um----um---");
                yield return new TestCaseData('o', "-um----um---");
                yield return new TestCaseData('y', "-um--y-um--y");
                yield return new TestCaseData('d', "-um--yDum--y");
                yield return new TestCaseData('h', "Hum--yDum--y");
                yield return new TestCaseData('T', "Hum-tyDum-ty");
                yield return new TestCaseData('p', "HumptyDumpty");
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
