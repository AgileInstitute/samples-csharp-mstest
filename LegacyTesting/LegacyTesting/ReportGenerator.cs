namespace LegacyTesting;

public class ReportGenerator {
    private Account account;
    public ReportGenerator(String accountNumber) : this(FinancialDatabase.QueryAccount(accountNumber)) {
    }

    public ReportGenerator(Account account) {
        this.account = account;
    }

    public void OpenOrderReport() {
        Order[] openOrders = FinancialDatabase.QueryOrders(
            "open", account.AccountNumber(), DateTime.Now);
        FormatOpenOrderReport(openOrders, new OutputProxy(Console.Out));
    }

    public void FormatOpenOrderReport(Order[] openOrders, OutputProxy output) {
        if (openOrders.Length == 0) {
            output.WriteLine("--- [You have no open orders]");
        } else {
            output.WriteLine("| {0, 8} | {1, 8} | {2, 8} | {3, 8} | {4, 8} | {5, 8} |",
                "Order", "Type", "Status", "Symbol", "Shares", "Price");
            foreach (Order order in openOrders) {
                output.WriteLine("| {0, 8} | {1, 8} | {2, 8} | {3, 8} | {4, 8} | {5, 8} |",
                    order.Id,
                    order.Type,
                    order.Status,
                    order.Symbol,
                    order.Shares,
                    order.AppropriateDisplayPrice());
            }
        }
    }
}






