public class SaleItem
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double ItemCost { get; set; }

    public SaleItem(string name, double itemCost, string category = "Misc")
    {
        Name = name ?? "Toilet Water";
        ItemCost = itemCost;
        Category = category;
    }
}