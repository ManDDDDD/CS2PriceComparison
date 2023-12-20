using System.Text.Json;

namespace CS2PriceComparison;

public class UserInput
{
    public string GetItemType()
    {
        string itemType = "";
        Console.WriteLine("Type of Item");
        Console.WriteLine("1. Gun Skin");
        Console.WriteLine("2. Knife");
        Console.WriteLine("3. Gloves");
        Console.WriteLine("4. Sticker");
        Console.WriteLine("5. Agent");
        Console.WriteLine("6. Container");
        Console.WriteLine("Enter: ");
        
        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                return GetGunType();
            case "2":
                itemType = "Knife";
                break;
            case "3":
                itemType = "Gloves";
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

        return GetGun(gunType);
    }

    private string GetGun(string gunType)
    {
        return "";
    }



}