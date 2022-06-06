public class ItemUnit : IInventoryItem
{
    public int ItemStock { get; set; }

    //TODO
    public override float GetStock()
    {
        throw new NotImplementedException();
    }
    //TODO
    public override void SetStock(float stock)
    {
        ItemStock = (int)stock;
    }
}