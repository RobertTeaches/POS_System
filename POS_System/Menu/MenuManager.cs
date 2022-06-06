using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;


public class MenuManager
{
    public List<SaleItem> Menu { get; set; } = new();    


    //TODO?
    public void LoadMenu(string menuFilePath, InventoryManager loadedInventory)
    {
        string jsonText = File.ReadAllText(menuFilePath);
        if (jsonText != null)
        {
            JsonNode allJson = JsonNode.Parse(jsonText)!;
            var root = allJson.Root;
            var items = root["items"]!.AsArray();

            foreach (var item in items)
            {
                
            }


        }
    }
}