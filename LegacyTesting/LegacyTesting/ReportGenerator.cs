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
            "open", account.accountNumber(), DateTime.Now);
        FormatOpenOrderReport(openOrders, new OutputProxy(Console.Out));
    }

    public void FormatOpenOrderReport(Order[] openOrders, OutputProxy output) {
        if (openOrders.Length == 0) {
            output.WriteLine("--- [You have no open orders]");
        } else {
            output.WriteLine("| %8s | %8s | %8s | %8s | %8s | %8s |%n",
                "Order", "Type", "Status", "Symbol", "Shares", "Price");
            foreach (Order order in openOrders) {
                output.WriteLine("| %8s | %8s | %8s | %8s | %8d | %8d |%n",
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






