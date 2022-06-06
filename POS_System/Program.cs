
public class POS
{

    static List<Transaction> transactions = new();
    static List<Order> orderQueue = new();
    static double netRevenue = 0;

    static InventoryManager inventoryManager = new();
    /* TODO: Allow 'customer' interaction from Command line
    1. Should ask for customer name, and allow them to respond
      1a. Is also responsible for making sure custName is valid using ValidateName()
    2. Should create a new order & assign it an OrderID that has not been previously used
    3. Should create a new customer, prompting the customer for any information you may need from them
    4. Once the order is created, you should begin asking the customer what Item they would like to add,
       or if they would like to remove an item or stop adding food
       3a You may also give an option to cancel the order
    5. Once the customer has finished adding items to their order, you should 'Finalize' the order, and Calculate the Cost
       using appropriate methods
    5. Once the order is finalized, a new transaction should be made
    6. The new transaction should be added to the transactions list, and the final order should be 
       added to the end of the orderQueue
    */
    public static void HandleCustomer()
    {

    }

    //TODO: Make sure inputted names are clean/washed
    public static string ValidateName(string name)
    {
        return name;
    }
    //TODO: Make sure SaleItem exists and can be ordered
    public static bool IsValidItem(string item)
    {
        return true;
    }

    static string[] custNames = { "Bob", "Jeremy", "Mary", "Mariah", "Jane", "Zane", "Rachel" };

    public static void Main(string[] args)
    {
        inventoryManager.LoadInventoryItems();

    }

    static void DrawMenu()
    {

    }
}