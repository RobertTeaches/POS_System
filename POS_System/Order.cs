public class Order
{
    public int OrderID { get; set; }
    public List<SaleItem> OrderItems { private get; set; } = new();
    public double Cost { get; set; }
    public bool IsFinilized { get; private set; } = false;

    //TODO: Finish this function, name explanatory
    public void PrintOrder()
    {

    }
    //TODO: Finish this function, name explanatory
    //(Also responsible for assigned a final value to Cost)
    public double CalculateCost()
    {
        return 0.0;
    }
    public void AddToOrder(SaleItem item)
    {
        if (IsFinilized) return;
        OrderItems.Add(item);
    }
    public void RemoveFromOrder(SaleItem item)
    {
        if (IsFinilized) return;
        OrderItems.Remove(item);
    }
    public void RemoveFromOrder(string itemName)
    {
        if (IsFinilized) return;

        OrderItems.RemoveAt(OrderItems.FindIndex((value) => itemName == value.Name));
    }

    public void Finalize()
    {
        IsFinilized = true;
    }
    
}