using CodeCasing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCasingTest
{
    [TestClass]
    public class ExpandToTitleCaseTests
    {
        [TestMethod]
        public void ExpandToTitleCasePassingHungarianNotationReturnsTitle()
        {
            string input = "boxFullyComplete";
            string expected = "Box Fully Complete";

            string result = input.ExpandToTitleCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExpandToTitleCasePassingPascalCaseReturnsAsTitle()
        {
            string input = "GoBigRed";
            string expected = "Go Big Red";

            string result = input.ExpandToTitleCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExpandToTitleCasePassingScreamingSnakeCaseReturnsTitle()
        {
            string input = "SHIPPED_PRODUCTS";
            string expected = "Shipped Products";

            string result = input.ExpandToTitleCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExpandToTitleCasePassingSentenceUppercasesFirstLetters()
        {
            string input = "Take me out to the ball game";
            string expected = "Take Me Out To The Ball Game";

            string result = input.ExpandToTitleCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExpandToTitleCasePassingSingleLowerWordConvertsFirstLetterUpperCased()
        {
            string input = "kyle";
            string expected = "Kyle";

            string result = input.ExpandToTitleCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExpandToTitleCasePassingSnakeCaseReturnsTitle()
        {
            string input = "dumb_and_dumber";
            string expected = "Dumb And Dumber";

            string result = input.ExpandToTitleCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExpandToTitleCasePassingSpinalCaseReturnsTitle()
        {
            string input = "my-hosting-class";
            string expected = "My Hosting Class";

            string result = input.ExpandToTitleCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExpandToTitleCasePassingTrainCaseReturnsTitle()
        {
            string input = "Would-you-could-you";
            string expected = "Would You Could You";

            string result = input.ExpandToTitleCase();
            Assert.AreEqual(expected, result);
        }
    }
}