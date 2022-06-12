public class SaleItem
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double ItemCost { get; set; }

    public IInventoryItem[] RequiredStock { get; private set; }

    public decimal CostToMake 
    { 
        //TODO
        get
        {
            return 0.0m;
        }
    }

    public SaleItem(string name, double itemCost, string category = "Misc", params IInventoryItem[]? itemsRequired)
    {
        Name = name ?? "Toilet Water";
        ItemCost = itemCost;
        Category = category;
        RequiredStock = itemsRequired;
    }
}