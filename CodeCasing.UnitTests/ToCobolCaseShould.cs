namespace CodeCasing.UnitTests;

[TestClass]
public class ToCobolCaseShould
{
    [DataTestMethod]
    [DataRow("aBlinkingLight", "A-BLINKING-LIGHT")]
    [DataRow("GoForTheGold", "GO-FOR-THE-GOLD")]
    [DataRow("DINO_ZAMBONI_DRIVER", "DINO-ZAMBONI-DRIVER")]
    [DataRow("chevy", "CHEVY")]
    [DataRow("Production_Numbers_View", "PRODUCTION-NUMBERS-VIEW")]
    [DataRow("spinal-tap-the-movie", "SPINAL-TAP-THE-MOVIE")]
    [DataRow("Four-on-monopoly", "FOUR-ON-MONOPOLY")]
    [DataRow("", "")]
    [DataRow(" ", "-")]
    [DataRow("NO-CHANGE-HERE", "NO-CHANGE-HERE")]
    [DataRow("arizona-league-ball", "ARIZONA-LEAGUE-BALL")]
    [DataRow("rub_the_lamp", "RUB-THE-LAMP")]
    [DataRow("Good Bad Ugly", "GOOD-BAD-UGLY")]
    [DataRow("Polar-express", "POLAR-EXPRESS")]
    public void ReturnCorrectlyGivenInput(string input, string expected)
    {
        var result = input.ToCobolCase();
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionWhenInputIsNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => ((string)null!).ToCobolCase());
    }
}