namespace CodeCasing.UnitTests.CasingExtensionsTests;

[TestClass]
public class ToSnakeCaseShould
{
    [DataTestMethod]
    [DataRow("aBlinkingLight", "a_blinking_light")]
    [DataRow("GoForTheGold", "go_for_the_gold")]
    [DataRow("DINO_ZAMBONI_DRIVER", "dino_zamboni_driver")]
    [DataRow("Chevy", "chevy")]
    [DataRow("Production_Numbers_View", "production_numbers_view")]
    [DataRow("spinal-tap-the-movie", "spinal_tap_the_movie")]
    [DataRow("Four-on-monopoly", "four_on_monopoly")]
    [DataRow("", "")]
    [DataRow(" ", "_")]
    [DataRow("no_change_here", "no_change_here")]
    [DataRow("Go forth and prosper", "go_forth_and_prosper")]
    [DataRow("rattle_out_loud", "rattle_out_loud")]
    [DataRow("Our Family Home", "our_family_home")]
    [DataRow("Caboose-on-the-loose", "caboose_on_the_loose")]
    public void ReturnCorrectlyGivenInput(string input, string expected)
    {
        var result = input.ToSnakeCase();
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionWhenInputIsNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => ((string)null!).ToSnakeCase());
    }
}