namespace CodeCasing.UnitTests.CasingExtensionsTests;

[TestClass]
public class ToPascalCaseShould
{
    [DataTestMethod]
    [DataRow("boxCarWilly", "BoxCarWilly")]
    [DataRow("SILLY_SLITHER_SOUND", "SillySlitherSound")]
    [DataRow("Grandly enter now", "GrandlyEnterNow")]
    [DataRow("exponent", "Exponent")]
    [DataRow("LEADERSHIP", "Leadership")]
    [DataRow("SNAKE", "Snake")]
    [DataRow("", "")]
    [DataRow(" ", "")]
    [DataRow("NoChangeHere", "NoChangeHere")]
    [DataRow("arizona-league-ball", "ArizonaLeagueBall")]
    [DataRow("rub_the_lamp", "RubTheLamp")]
    [DataRow("Good Bad Ugly", "GoodBadUgly")]
    [DataRow("Polar-express", "PolarExpress")]
    public void ReturnCorrectlyGivenInput(string input, string expected)
    {
        var result = input.ToPascalCase();
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionWhenInputIsNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => ((string)null!).ToPascalCase());
    }
}