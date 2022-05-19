
public class POS
{

    static SaleItem[] itemsForSale = { new SaleItem("Cookie", 1, 25),
                                new SaleItem("Brownie", 1.75, 20),
                                new SaleItem("Cake Slice", 2, 20),
                                new SaleItem("Muffin", 1.25, 30),
                                new SaleItem("Pie", 8, 10)
                              };
    static List<Transaction> transactions = new();
    static double netRevenue = 0;


    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Point of Sale System!");

        MakePurchase("Cookie", 3, "Bob", true);
        Console.WriteLine("Thank ya Bob! Enjoy the Cookies!");
        Thread.Sleep(500);

        MakePurchase("Pie", 1, "Joe", false);
        Console.WriteLine("Good Seing you Joe!");
        Thread.Sleep(750);

        MakePurchase("Muffin", 1, "Bob", true);
        Console.WriteLine("I see you came back for our Muffins!");
        Thread.Sleep(750);

        MakePurchase("Brownie", 5, "Sally", false);
        Console.WriteLine("Loading up for a good night, Sal? You'll love these!");
        Thread.Sleep(750);

        MakePurchase("Cake Slice", 1, "Gen", true);
        Console.WriteLine("Enjoy your slice Gen!");
        Thread.Sleep(350);

        Console.WriteLine("Oh, Hi again Bob! You want your reciept? Sure thing! One sec...");
        Thread.Sleep(1500);
        PrintCustomerReciept("Bob");

        Thread.Sleep(500);
        Console.WriteLine("Have a good day bob! See ya soon.");

        Console.WriteLine($"Phew, what a day! We sold ${netRevenue} worth of Goods!");
    }

    /*  TODO: Finish this function
     *  This is responsible for handling a new purchase of a SaleItem with a Customer
     *  1. Should create a new Customer with the appropriate information
     *  2. Should craete a new Transaction with the appropriate SaleItem, Customer, & Cost
     *      2a. This function is also responsible for calculating the cost
     *  3. Should update the count of the appropiate SaleItem
     *  4. Should add the newly created Transaction to the list of Transactions stored
     *  5. Should ADD the calculated Cost to net revenue
     */
    public static void MakePurchase(string itemName, int itemAmount, string customerName, bool paidCash)
    {

    }
    /*  TODO: Finish this function
     *  1. Should loop through transactions List and find all transactions that fit the Customer's Name
     *  2. Should --print-- out all Customer transactions in a readable format, with all information included
     */ 
    public static void PrintCustomerReciept(string custName)
    {

    }


}