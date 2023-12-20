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
                itemType = "Gun Skin";
                break;
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
}