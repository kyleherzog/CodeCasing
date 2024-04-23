namespace CodeCasing.UnitTests.CasingExtensionsTests;

[TestClass]
public class ToKebabCaseShould
{
    [DataTestMethod]
    [DataRow("aBlinkingLight", "a-blinking-light")]
    [DataRow("GoForTheGold", "go-for-the-gold")]
    [DataRow("DINO_ZAMBONI_DRIVER", "dino-zamboni-driver")]
    [DataRow("Chevy", "chevy")]
    [DataRow("Production_Numbers_View", "production-numbers-view")]
    [DataRow("spinal-tap-the-movie", "spinal-tap-the-movie")]
    [DataRow("Four-on-monopoly", "four-on-monopoly")]
    [DataRow("", "")]
    [DataRow(" ", "-")]
    [DataRow("no-change-here", "no-change-here")]
    [DataRow("Go forth and prosper", "go-forth-and-prosper")]
    [DataRow("rattle_out_loud", "rattle-out-loud")]
    [DataRow("Our Family Home", "our-family-home")]
    [DataRow("Caboose-on-the-loose", "caboose-on-the-loose")]
    public void ReturnCorrectlyGivenInput(string input, string expected)
    {
        var result = input.ToKebabCase();
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionWhenInputIsNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => ((string)null!).ToKebabCase());
    }
}