public class ItemUnit : IInventoryItem
{
    public int ItemStock { get; set; }

    //TODO
    public override float GetStock()
    {
        return (int)ItemStock;
    }
    //TODO
    public override void SetStock(float stock)
    {
        ItemStock = (int)stock;
    }

    public override bool TakeFromStock(float amountToTake)
    {
        if ((float)ItemStock - amountToTake < 0) return false;
        ItemStock -= (int)Math.Round(amountToTake, 0, MidpointRounding.AwayFromZero);
        return true;
    }
}