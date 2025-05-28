namespace LegacyTesting;

public class FinancialDatabase
{
    public static Account QueryAccount(string accountNumber)
    {
        return new Account();
    }

    public static Order[] QueryOrders(string open, object accountNumber, object now)
    {
        return new Order[] {
            new Order("B5AC8", "MARKET", "OPEN", "LXABC", 400, 245),
            new Order("B3AAE", "MARKET", "OPEN", "LXEGF", 1000, 421),
            new Order("F5A62", "STOP", "OPEN", "LXODP", 200, 2200),
            new Order("6BE11", "LIMIT", "OPEN", "LXSPL", 4, 186282),
            new Order("2C874", "MARKET", "OPEN", "LXMDI", 1200, 82),
            new Order("ACE42", "LIMIT", "OPEN", "LXRCM", 42, 7000),
        };
    }
}

public class Account
{
    public string AccountNumber()
    {
        return "16309";
    }
}
