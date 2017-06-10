using CodeCasing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCasingTest
{
    [TestClass]
    public class ToSnakeCaseTests
    {
        [TestMethod]
        public void ToSnakeCasePassingHungarianCaseReturnsSnaked()
        {
            string input = "boxBorderSize";
            string expected = "box_border_size";

            string result = input.ToSnakeCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToSnakeCasePassingPascalCaseReturnsSnaked()
        {
            string input = "ReachForTheSky";
            string expected = "reach_for_the_sky";

            string result = input.ToSnakeCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToSnakeCasePassingScreamingSnakeReturnsSnaked()
        {
            string input = "MOVIE_POPCORN";
            string expected = "movie_popcorn";

            string result = input.ToSnakeCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToSnakeCasePassingSentenceReturnsSnaked()
        {
            string input = "Peter hops down the trail";
            string expected = "peter_hops_down_the_trail";

            string result = input.ToSnakeCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToSnakeCasePassingSingleWordIsLowerCased()
        {
            string input = "Revelation";
            string expected = "revelation";

            string result = input.ToSnakeCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToSnakeCasePassingSpinalReturnsSnaked()
        {
            string input = "over-the-hedge";
            string expected = "over_the_hedge";

            string result = input.ToSnakeCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToSnakeCasePassingTitleReturnsSnaked()
        {
            string input = "Home Sweet Home";
            string expected = "home_sweet_home";

            string result = input.ToSnakeCase();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToSnakeCasePassingTrainCaseReturnsSnaked()
        {
            string input = "Riding-the-rails";
            string expected = "riding_the_rails";

            string result = input.ToSnakeCase();
            Assert.AreEqual(expected, result);
        }
    }
}