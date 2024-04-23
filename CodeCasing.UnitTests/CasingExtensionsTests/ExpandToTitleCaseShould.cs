namespace CodeCasing.UnitTests.CasingExtensionsTests;

[TestClass]
public class ExpandToTitleCaseShould
{
    [DataTestMethod]
    [DataRow("aBlinkingLight", "A Blinking Light")]
    [DataRow("GoForTheGold", "Go For The Gold")]
    [DataRow("DINO_ZAMBONI_DRIVER", "Dino Zamboni Driver")]
    [DataRow("chevy", "Chevy")]
    [DataRow("Production_Numbers_View", "Production Numbers View")]
    [DataRow("spinal-tap-the-movie", "Spinal Tap The Movie")]
    [DataRow("Four-on-monopoly", "Four On Monopoly")]
    [DataRow("", "")]
    [DataRow(" ", " ")]
    [DataRow("No Change Here", "No Change Here")]
    public void ReturnCorrectlyGivenInput(string input, string expected)
    {
        var result = input.ExpandToTitleCase();
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionWhenInputIsNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => ((string)null!).ExpandToTitleCase());
    }
}