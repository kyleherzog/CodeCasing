namespace CodeCasing.UnitTests.CasingExtensionsTests;

[TestClass]
public class ToHungarianCaseShould
{
    [DataTestMethod]
    [DataRow("aBlinkingLight", "aBlinkingLight")]
    [DataRow("GoForTheGold", "goForTheGold")]
    [DataRow("DINO_ZAMBONI_DRIVER", "dinoZamboniDriver")]
    [DataRow("chevy", "chevy")]
    [DataRow("Production_Numbers_View", "productionNumbersView")]
    [DataRow("spinal-tap-the-movie", "spinalTapTheMovie")]
    [DataRow("Four-on-monopoly", "fourOnMonopoly")]
    [DataRow("", "")]
    [DataRow(" ", "")]
    [DataRow("noChangeHere", "noChangeHere")]
    public void ReturnCorrectlyGivenInput(string input, string expected)
    {
        var result = input.ToHungarianCase();
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionWhenInputIsNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => ((string)null!).ToHungarianCase());
    }
}