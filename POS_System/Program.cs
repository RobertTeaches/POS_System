
public class POS
{

    static List<Transaction> transactions = new();
    static List<Order> orderQueue = new();
    static double netRevenue = 0;

    static InventoryManager inventoryManager = new();
    
    public static void Main(string[] args)
    {
        inventoryManager.LoadInventoryItems();
        inventoryManager.GetItemByName("Potato")?.TakeFromStock(10);
        inventoryManager.PrintRemainingInventory(true);
    }

}