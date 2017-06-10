using CodeCasing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCasingTest
{
    [TestClass]
    public class ToHungarianCaseTests
    {
        [TestMethod]
        public void ToHungarianCasePassingPascalCaseReturnsHungarian()
        {
            string input = "PabloPaintsPictures";
            string expected = "pabloPaintsPictures";

            string result = input.ToHungarianCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToHungarianCasePassingScreamingSnakeReturnsHungarian()
        {
            string input = "ARIZONA_SUPER_FAN";
            string expected = "arizonaSuperFan";

            string result = input.ToHungarianCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToHungarianCasePassingSentenceReturnsHungarian()
        {
            string input = "Arms wide open";
            string expected = "armsWideOpen";

            string result = input.ToHungarianCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToHungarianCasePassingSingleWordHasFirstLetterLowerCased()
        {
            string input = "Justified";
            string expected = "justified";

            string result = input.ToHungarianCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToHungarianCasePassingSnakeReturnsHungarian()
        {
            string input = "mouse-eater";
            string expected = "mouseEater";

            string result = input.ToHungarianCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToHungarianCasePassingSpinalCaseReturnsHungarian()
        {
            string input = "stretch-for-fitness";
            string expected = "stretchForFitness";

            string result = input.ToHungarianCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToHungarianCasePassingTitleReturnsHungarian()
        {
            string input = "Eyes Wide Shut";
            string expected = "eyesWideShut";

            string result = input.ToHungarianCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToHungarianCasePassingTrainCaseReturnsHungarian()
        {
            string input = "Wistle-blow-warning";
            string expected = "wistleBlowWarning";

            string result = input.ToHungarianCase();
            Assert.AreEqual(expected, result);
        }
    }
}