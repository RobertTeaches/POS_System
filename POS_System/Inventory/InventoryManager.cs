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

    public const string _startingInventoryFileName = "./Inventory/starting_inventory.json";
    public const string _saleItemRecipesFileName = "./Menu/sale_item_recipes.json";


    public List<IInventoryItem> LoadInventoryItems()
    {
        string jsonText = File.ReadAllText(_startingInventoryFileName);
        if (jsonText != null)
        {
            JsonNode allJson = JsonNode.Parse(jsonText)!;
            var root = allJson.Root;
            var items = root["inventoryItems"]!.AsArray();

            foreach (var item in items)
            {
                var type = item!["type"]!.GetValue<String>();
                if (type == null) continue;
                IInventoryItem? inventoryItem = (type == "Unit") ? new ItemUnit() : new ItemWeight();
                inventoryItem.SetStock(item["amount"]!.GetValue<int>());
                inventoryItem.DateRecieved = DateTime.Now;
                inventoryItem.Name = item!["name"]!.GetValue<string>();
                inventoryItem.CostPerStock = item!["cost"]!.GetValue<decimal>();
                InventoryItems.Add(inventoryItem);
            }


        }
        return InventoryItems;
    }


    //TODO
    public string PrintRemainingInventory(bool outputToConsole = true)
    {
        string s = "";
        foreach (var i in InventoryItems)
        {
            s += $"{i.Name}: {i.GetStock()}";
            if (i is ItemWeight weight)
            {
                s += weight.unitType.ToString();
            }
            s += $"\nRecieved: {i.DateRecieved}\n\n";
        }
        if (outputToConsole) Console.WriteLine(s);
        return s;
    }

    //TODO
    public IInventoryItem? GetItemByName(string itemName)
    {
        foreach (var i in InventoryItems)
        {
            if (i.Name == itemName)
            {
                return i;
            }
        }
        return null;
    }

}