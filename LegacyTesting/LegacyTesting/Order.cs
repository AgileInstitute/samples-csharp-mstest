namespace LegacyTesting;

public class Order {
    private string id;
    private string type;
    private string status;
    private string symbol;
    private int shares;
    private int price;

    public Order(string id, string type, string status, string symbol, int shares, int price) {
        this.id = id;
        this.type = type;
        this.status = status;
        this.symbol = symbol;
        this.shares = shares;
        this.price = price;
    }

    public string Id => id;

    public string Type => type;

    public string Status => status;

    public string Symbol => symbol;

    public int Shares => shares;

    public int AppropriateDisplayPrice() {
        return price;
    }
}
