using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Transaction
{
    public Customer _Customer { get; set; }
    public DateTime TransactionTime;
    public Order FinalOrder;
    public Transaction(Customer customer, double cost, DateTime transactionTime, Order order)
    {
        _Customer = customer;
        TransactionTime = transactionTime;
        FinalOrder = order;
    }
}

