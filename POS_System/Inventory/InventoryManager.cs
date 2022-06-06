using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Nodes;

public class InventoryManager
{
    public List<IInventoryItem> InventoryItems { get; set; } = new();

    public const string _startingInventoryFileName = "C:/Users/rober/Source/Repos/RobertTeaches/POS_System/POS_System/Inventory/starting_inventory.json";
    public const string _saleItemRecipesFileName= "sale_item_recipes.json";


    public void LoadInventoryItems()
    {
        string jsonText = File.ReadAllText(_startingInventoryFileName);
        if (jsonText != null)
        {
            JsonNode allJson = JsonNode.Parse(jsonText)!;
            var root = allJson.Root;
            var items = root["inventoryItems"]!.AsArray();

            foreach(var item in items)
            {
                var type = item!["type"]!.GetValue<String>();
                if (type == null) continue;
                IInventoryItem? inventoryItem = (type == "Unit")? new ItemUnit(): new ItemWeight();
                inventoryItem.SetStock(item["amount"]!.GetValue<int>());
                inventoryItem.DateRecieved = DateTime.Now;
                inventoryItem.Name = item!["name"]!.GetValue<string>();
                inventoryItem.CostPerStock = item!["cost"]!.GetValue<decimal>();
                InventoryItems.Add(inventoryItem);
            }


        }
    }
}

