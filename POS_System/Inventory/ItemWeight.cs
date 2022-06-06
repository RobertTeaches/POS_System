public class ItemWeight : IInventoryItem
{
    public enum WeightUnit
    {
        KILOGRAMS,
        GRAMS,
        MILIGRAMS
    }
    public decimal ItemStock { get; set; }
    public WeightUnit unitType { get; set; }

    //TODO
    public override float GetStock()
    {
        return (float)ItemStock;
    }
    //TODO
    public override void SetStock(float stock)
    {
        ItemStock = (decimal)stock;
    }

    public override bool TakeFromStock(float amountToTake)
    {
        return true;
    }
}