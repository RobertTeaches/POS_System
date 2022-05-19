public class Customer
{
    public string CustomerID { get; set; }
    public string CustomerName { get; set; }
    public string CustomerCreditInfo { get; set; } = "";
    public bool PaidCash { get; set; }

    public Customer(string customerName, bool paidCash)
    {
        PaidCash = paidCash;
        CustomerID = Guid.NewGuid().ToString("N");
        CustomerName = customerName ?? "Nancy Drew";
        if(!PaidCash)
            CustomerCreditInfo = GenerateCreditCardNumber();

    }

    internal string GenerateCreditCardNumber()
    {
        string creditCardNumber = string.Empty;
        var r = new Random();
        for (int i = 0; i < 4; i++)
        {
            for (int ii = 0; ii < 4; ii++)
            {
                creditCardNumber += r.Next(10).ToString();
            }
            
            if(i < 3) creditCardNumber += " ";
        }

        return creditCardNumber;
    }
}