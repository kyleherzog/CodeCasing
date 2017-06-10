using CodeCasing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCasingTest
{
    [TestClass]
    public class ToScreamingSnakeCaseTests
    {
        [TestMethod]
        public void ToScreamingSnakeCasePassingHungarianCaseReturnsScreamingSnaked()
        {
            string input = "aWiseGuy";
            string expected = "A_WISE_GUY";

            string result = input.ToScreamingSnakeCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToScreamingSnakeCasePassingPascalCaseReturnsScreamingSnaked()
        {
            string input = "SuperFastTyper";
            string expected = "SUPER_FAST_TYPER";

            string result = input.ToScreamingSnakeCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToScreamingSnakeCasePassingSentenceReturnsScreamingSnaked()
        {
            string input = "Go forth and prosper";
            string expected = "GO_FORTH_AND_PROSPER";

            string result = input.ToScreamingSnakeCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToScreamingSnakeCasePassingSingleWordIsUpperCased()
        {
            string input = "Hope";
            string expected = "HOPE";

            string result = input.ToScreamingSnakeCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToScreamingSnakeCasePassingSnakeReturnsScreamingSnaked()
        {
            string input = "rattle_out_loud";
            string expected = "RATTLE_OUT_LOUD";

            string result = input.ToScreamingSnakeCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToScreamingSnakeCasePassingSpinalReturnsScreamingSnaked()
        {
            string input = "back-breaking-work";
            string expected = "BACK_BREAKING_WORK";

            string result = input.ToScreamingSnakeCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToScreamingSnakeCasePassingTitleReturnsScreamingSnaked()
        {
            string input = "Our Family Home";
            string expected = "OUR_FAMILY_HOME";

            string result = input.ToScreamingSnakeCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToScreamingSnakeCasePassingTrainCaseReturnsScreamingSnaked()
        {
            string input = "Caboose-on-the-loose";
            string expected = "CABOOSE_ON_THE_LOOSE";

            string result = input.ToScreamingSnakeCase();
            Assert.AreEqual(expected, result);
        }
    }
}