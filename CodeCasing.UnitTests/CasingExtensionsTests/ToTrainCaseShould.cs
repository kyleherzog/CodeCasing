namespace CodeCasing.UnitTests.CasingExtensionsTests;

[TestClass]
public class ToTrainCaseShould
{
    [DataTestMethod]
    [DataRow("aBlinkingLight", "A-blinking-light")]
    [DataRow("GoForTheGold", "Go-for-the-gold")]
    [DataRow("DINO_ZAMBONI_DRIVER", "Dino-zamboni-driver")]
    [DataRow("chevy", "Chevy")]
    [DataRow("Production_Numbers_View", "Production-numbers-view")]
    [DataRow("spinal-tap-the-movie", "Spinal-tap-the-movie")]
    [DataRow("Four-on-monopoly", "Four-on-monopoly")]
    [DataRow("", "")]
    [DataRow(" ", "-")]
    [DataRow("No-change-here", "No-change-here")]
    [DataRow("Go forth and prosper", "Go-forth-and-prosper")]
    [DataRow("rattle_out_loud", "Rattle-out-loud")]
    [DataRow("Our Family Home", "Our-family-home")]
    [DataRow("Caboose-on-the-loose", "Caboose-on-the-loose")]
    public void ReturnCorrectlyGivenInput(string input, string expected)
    {
        var result = input.ToTrainCase();
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionWhenInputIsNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => ((string)null!).ToTrainCase());
    }
}