namespace CodeCasing.UnitTests.CasingExtensionsTests;

[TestClass]
public class ToFlatCaseShould
{
    [DataTestMethod]
    [DataRow("aBlinkingLight", "ablinkinglight")]
    [DataRow("GoForTheGold", "goforthegold")]
    [DataRow("DINO_ZAMBONI_DRIVER", "dinozambonidriver")]
    [DataRow("chevy", "chevy")]
    [DataRow("Production_Numbers_View", "productionnumbersview")]
    [DataRow("spinal-tap-the-movie", "spinaltapthemovie")]
    [DataRow("Four-on-monopoly", "fouronmonopoly")]
    [DataRow("", "")]
    [DataRow(" ", "")]
    [DataRow("nochangehere", "nochangehere")]
    [DataRow("Go forth and prosper", "goforthandprosper")]
    [DataRow("rattle_out_loud", "rattleoutloud")]
    [DataRow("Our Family Home", "ourfamilyhome")]
    [DataRow("Caboose-on-the-loose", "cabooseontheloose")]
    public void ReturnCorrectlyGivenInput(string input, string expected)
    {
        var result = input.ToFlatCase();
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionWhenInputIsNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => ((string)null!).ToFlatCase());
    }
}