using CodeCasing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCasingTest
{
    [TestClass]
    public class ToPascalCaseTests
    {
        [TestMethod]
        public void ToPascalCasePassingHungarianCaseReturnsPascalCase()
        {
            string input = "boxCarWilly";
            string expected = "BoxCarWilly";

            string result = input.ToPascalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToPascalCasePassingScreamingSnakeReturnsPascalCase()
        {
            string input = "SILLY_SLITHER_SOUND";
            string expected = "SillySlitherSound";

            string result = input.ToPascalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToPascalCasePassingSentenceReturnsPascalCase()
        {
            string input = "Grandly enter now";
            string expected = "GrandlyEnterNow";

            string result = input.ToPascalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToPascalCasePassingSingleWordHasFirstLetterUpperCased()
        {
            string input = "exponent";
            string expected = "Exponent";

            string result = input.ToPascalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToPascalCasePassingSingleWordScreamingSnakeReturnsPascalCase()
        {
            string input = "LEADERSHIP";
            string expected = "Leadership";

            string result = input.ToPascalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToPascalCasePassingSnakeReturnsPascalCase()
        {
            string input = "arizona-league-ball";
            string expected = "ArizonaLeagueBall";

            string result = input.ToPascalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToPascalCasePassingSpinalCaseReturnsPascalCase()
        {
            string input = "rub-down-help";
            string expected = "RubDownHelp";

            string result = input.ToPascalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToPascalCasePassingTitleReturnsPascalCase()
        {
            string input = "Good Bad Ugly";
            string expected = "GoodBadUgly";

            string result = input.ToPascalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToPascalCasePassingTrainCaseReturnsPascalCase()
        {
            string input = "Polar-express";
            string expected = "PolarExpress";

            string result = input.ToPascalCase();
            Assert.AreEqual(expected, result);
        }
    }
}