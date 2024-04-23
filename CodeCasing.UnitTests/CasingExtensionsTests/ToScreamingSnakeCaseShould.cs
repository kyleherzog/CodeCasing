namespace CodeCasing.UnitTests.CasingExtensionsTests;

[TestClass]
public class ToScreamingSnakeCaseShould
{
    [DataTestMethod]
    [DataRow("aBlinkingLight", "A_BLINKING_LIGHT")]
    [DataRow("GoForTheGold", "GO_FOR_THE_GOLD")]
    [DataRow("DINO_ZAMBONI_DRIVER", "DINO_ZAMBONI_DRIVER")]
    [DataRow("Chevy", "CHEVY")]
    [DataRow("Production_Numbers_View", "PRODUCTION_NUMBERS_VIEW")]
    [DataRow("spinal-tap-the-movie", "SPINAL_TAP_THE_MOVIE")]
    [DataRow("Four-on-monopoly", "FOUR_ON_MONOPOLY")]
    [DataRow("", "")]
    [DataRow(" ", "_")]
    [DataRow("NO_CHANGE_HERE", "NO_CHANGE_HERE")]
    [DataRow("Go forth and prosper", "GO_FORTH_AND_PROSPER")]
    [DataRow("rattle_out_loud", "RATTLE_OUT_LOUD")]
    [DataRow("Our Family Home", "OUR_FAMILY_HOME")]
    [DataRow("Caboose-on-the-loose", "CABOOSE_ON_THE_LOOSE")]
    public void ReturnCorrectlyGivenInput(string input, string expected)
    {
        var result = input.ToScreamingSnakeCase();
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionWhenInputIsNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => ((string)null!).ToScreamingSnakeCase());
    }
}