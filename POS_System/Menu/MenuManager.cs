using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;


public class MenuManager
{
    public List<SaleItem> Menu { get; set; } = new();    



    public List<SaleItem>? LoadMenu(InventoryManager loadedInventory, string menuFilePath = "./Menu/sale_item_recipes.json")
    {
        if (loadedInventory.InventoryItems.Count == 0) return null;
        string jsonText = File.ReadAllText(menuFilePath);
        if (jsonText != null)
        {
            JsonNode allJson = JsonNode.Parse(jsonText)!;
            var root = allJson.Root;
            var items = root["items"]!.AsArray();

            foreach (var item in items)
            {
                SaleItem saleItem = new(item!["name"]!.GetValue<string>(), 0.0,item["category"]!.GetValue<string>(), null);
                Menu.Add(saleItem);
            }


        }
        return Menu;
    }


    //TODO
    //ASSUME LOADED INVENTORY AND MENU
    public bool CanMakeItem(string itemName)
    {

        return true;
    }

    //TODO
    public SaleItem? MakeItem(string itemName)
    {

        foreach(SaleItem saleItem in Menu)
        {
            if(saleItem.Name == itemName)
            {
                return saleItem;
            }
        }
        return null;
    }


    //TODO
    public void UnMakeItem(string itemName)
    {

    }
}