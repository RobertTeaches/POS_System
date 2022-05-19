using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Transaction
{
    internal Customer _Customer { get; set; }
    public double Cost { get; set; }
    public DateTime TransactionTime;
    public SaleItem[] items;

    public Transaction(Customer customer, double cost, DateTime transactionTime, SaleItem[] items)
    {
        _Customer = customer;
        Cost = cost;
        TransactionTime = transactionTime;
        this.items = items;
    }
}

public class SaleItem
{
    public string Name { get; set; }
    public double ItemCost { get; set; }
    public int StockLeft { get; set; }

    public SaleItem(string name, double itemCost, int stockLeft)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        ItemCost = itemCost;
        StockLeft = stockLeft;
    }
}