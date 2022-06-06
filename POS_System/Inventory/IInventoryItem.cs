public abstract class IInventoryItem
{
    public string Name { get; set; } = "Pile of Cow Poop";
    public DateTime DateRecieved { get; set; }
    public DateTime? ExpireyDate { get; set; }

    public decimal CostPerStock { get; set; }

    public abstract float GetStock();
    public abstract void SetStock(float stock);
    public abstract bool TakeFromStock(float amountToTake);
}
