using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LegacyTesting;

public class OutputProxySpy : OutputProxy
{
    public OutputProxySpy() : base(null)
    {
    }

    private string _actualOutputAsString = "";
    public override void WriteLine(string s) {
        _actualOutputAsString += s + "\n";
    }
    public override void WriteLine(
        string format, params object?[] arguments) {
        WriteLine(String.Format(format, arguments));
    }
    
    // For spying purposes only.
    public string ReadAllOutput() {
        return _actualOutputAsString;
    }
}

[TestClass]
public class CharacterizationTestsForLegacyReportGenerators
{
    private ReportGenerator _generator;
    private OutputProxySpy _output;

    [TestInitialize]
    public void SetUp()
    {
        Account unusedTestAccount = null;
        _generator = new ReportGenerator(unusedTestAccount);
        _output = new OutputProxySpy();
    }
    
    [TestMethod]
    public void OpenOrderReport_WhenNoOpenOrders() {
        _generator.FormatOpenOrderReport(new Order[] {}, _output);
        Assert.AreEqual("--- [You have no open orders]\n", _output.ReadAllOutput());
    }
    
    [TestMethod]
    public void OpenOrderReport_WithRepresentativeSample() {
        Order[] variousOpenOrders = new Order[] {
            new Order("B3AAE", "MARKET", "OPEN", "LXEGF", 1000, 421),
            new Order("F5A62", "STOP", "OPEN", "LXODP", 200, 2200),
            new Order("6BE11", "LIMIT", "OPEN", "LXSPL", 4, 186282),
        };
        var expectedOutput = 
            "|    Order |     Type |   Status |   Symbol |   Shares |    Price |\n"
            +
            "|    B3AAE |   MARKET |     OPEN |    LXEGF |     1000 |      421 |\n"
            +
            "|    F5A62 |     STOP |     OPEN |    LXODP |      200 |     2200 |\n"
            +
            "|    6BE11 |    LIMIT |     OPEN |    LXSPL |        4 |   186282 |\n";

        _generator.FormatOpenOrderReport(variousOpenOrders, _output);
        Assert.AreEqual(expectedOutput, _output.ReadAllOutput());
    }
}