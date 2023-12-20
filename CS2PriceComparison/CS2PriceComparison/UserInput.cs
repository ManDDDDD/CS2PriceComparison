using Newtonsoft.Json.Linq;

namespace CS2PriceComparison;

public class UserInput
{
    private JObject _jsonItems = JsonReader.LoadJson("../../../items.json");
    public string GetItemType()
    {
        string itemType = "";
        int index = 1;
        
        Console.WriteLine("Type of Item");
        foreach (KeyValuePair<string, JToken?> item in _jsonItems)
        {
            Console.WriteLine($"{index}. {item.Key}");
            index++;
        }
        Console.WriteLine("Enter:");
        
        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                return GetGunType();
            case "2":
                GetItem("Knife");
                break;
            case "3":
                itemType = "Gloves";
                GetItem("Gloves");
                break;
            case "4":
                itemType = "Sticker";
                break;
            case "5":
                itemType = "Agent";
                break;
            case "6":
                itemType = "Container";
                break;
            default:
                Console.Clear();
                Console.WriteLine("Invalid Input");
                GetItemType();
                break;
        }
        return itemType;

    }
    private string GetGunType()
    {
        string gunType = "";
        
        Console.WriteLine("Gun Type");
        Console.WriteLine("1. Pistol");
        Console.WriteLine("2. SMG");
        Console.WriteLine("3. Rifle");
        Console.WriteLine("4. Heavy");
        
        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                gunType = "Pistol";
                break;
            case "2":
                gunType = "SMG";
                break;
            case "3":
                gunType = "Rifle";
                break;
            case "4":
                gunType = "Heavy";
                break;
        }

        return GetGun($"{gunType}");
    }
    private string GetItem(string itemType)
    {
        int index = 1;
        Console.WriteLine(itemType);
        foreach (string item in _jsonItems[itemType])
        {
            Console.WriteLine($"{index}: {item}");
            index++;
        }
        return "";
    }
    private string GetGun(string itemType)
    {
        int index = 1;
        Console.WriteLine(itemType);
        foreach (string item in _jsonItems["Gun Skin"][itemType])
        {
            Console.WriteLine($"{index}: {item}");
            index++;
        }
        return "";
    }
}