using CodeCasing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCasingTest
{
    [TestClass]
    public class ToTrainCaseTests
    {
        [TestMethod]
        public void ToTrainCasePassingHungarianCaseReturnsTrained()
        {
            string input = "boxFullyLoaded";
            string expected = "Box-fully-loaded";

            string result = input.ToTrainCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToTrainCasePassingPascalCaseReturnsTrained()
        {
            string input = "CurvyWindyRoad";
            string expected = "Curvy-windy-road";

            string result = input.ToTrainCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToTrainCasePassingScreamingSnakeReturnsTrained()
        {
            string input = "VIEW_OVER_HILLS";
            string expected = "View-over-hills";

            string result = input.ToTrainCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToTrainCasePassingSentenceReturnsTrained()
        {
            string input = "Fully extended effort";
            string expected = "Fully-extended-effort";

            string result = input.ToTrainCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToTrainCasePassingSingleWordHasFirstLetterUpperCased()
        {
            string input = "worthy";
            string expected = "Worthy";

            string result = input.ToTrainCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToTrainCasePassingSnakeReturnsTrained()
        {
            string input = "reptile_gardens";
            string expected = "Reptile-gardens";

            string result = input.ToTrainCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToTrainCasePassingSpinalCaseReturnsTrained()
        {
            string input = "x-ray-club";
            string expected = "X-ray-club";

            string result = input.ToTrainCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToTrainCasePassingTitleReturnsTrained()
        {
            string input = "Hip Hip Horay";
            string expected = "Hip-hip-horay";

            string result = input.ToTrainCase();
            Assert.AreEqual(expected, result);
        }
    }
}