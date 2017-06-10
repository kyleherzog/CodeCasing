using CodeCasing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCasingTest
{
    [TestClass]
    public class ToSpinalCaseTests
    {
        [TestMethod]
        public void ToSpinalCasePassingHungarianCaseReturnsSpinal()
        {
            string input = "boxRubyReds";
            string expected = "box-ruby-reds";

            string result = input.ToSpinalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToSpinalCasePassingPascalCaseReturnsSpinal()
        {
            string input = "BigBlackKeyboard";
            string expected = "big-black-keyboard";

            string result = input.ToSpinalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToSpinalCasePassingScreamingSnakeReturnsSpinal()
        {
            string input = "HOLLER_LOUD";
            string expected = "holler-loud";

            string result = input.ToSpinalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToSpinalCasePassingSentenceReturnsSpinal()
        {
            string input = "Ride the wheel";
            string expected = "ride-the-wheel";

            string result = input.ToSpinalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToSpinalCasePassingSingleWordIsLowerCased()
        {
            string input = "Forever";
            string expected = "forever";

            string result = input.ToSpinalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToSpinalCasePassingSnakeReturnsSpinal()
        {
            string input = "catch_and_release";
            string expected = "catch-and-release";

            string result = input.ToSpinalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToSpinalCasePassingTitleReturnsSpinal()
        {
            string input = "Jump Jive Wail";
            string expected = "jump-jive-wail";

            string result = input.ToSpinalCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToSpinalCasePassingTrainCaseReturnsSpinal()
        {
            string input = "Chug-a-chug";
            string expected = "chug-a-chug";

            string result = input.ToSpinalCase();
            Assert.AreEqual(expected, result);
        }
    }
}