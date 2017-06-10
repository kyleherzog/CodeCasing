using CodeCasing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCasingTest
{
    [TestClass]
    public class ExpandToSentenceCaseTests
    {
        [TestMethod]
        public void ExpandToSentenceCasePassingHungarianNotationReturnsTitle()
        {
            string input = "aBlinkingLight";
            string expected = "A blinking light";

            string result = input.ExpandToSentenceCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExpandToSentenceCasePassingPascalCaseReturnsAsTitle()
        {
            string input = "GoForTheGold";
            string expected = "Go for the gold";

            string result = input.ExpandToSentenceCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExpandToSentenceCasePassingScreamingSnakeCaseReturnsTitle()
        {
            string input = "DINO_ZAMBONI_DRIVER";
            string expected = "Dino zamboni driver";

            string result = input.ExpandToSentenceCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExpandToSentenceCasePassingSingleLowerWordConvertsFirstLetterUpperCased()
        {
            string input = "chevy";
            string expected = "Chevy";

            string result = input.ExpandToSentenceCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExpandToSentenceCasePassingSnakeCaseReturnsTitle()
        {
            string input = "Production_Numbers_View";
            string expected = "Production numbers view";

            string result = input.ExpandToSentenceCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExpandToSentenceCasePassingSpinalCaseReturnsTitle()
        {
            string input = "spinal-tap-the-movie";
            string expected = "Spinal tap the movie";

            string result = input.ExpandToSentenceCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExpandToSentenceCasePassingTrainCaseReturnsTitle()
        {
            string input = "Four-on-monopoly";
            string expected = "Four on monopoly";

            string result = input.ExpandToSentenceCase();
            Assert.AreEqual(expected, result);
        }
    }
}