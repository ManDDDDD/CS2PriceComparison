namespace CS2PriceComparison;

public class Item
{
    private string _itemType;
    private string _quality;
    private string _itemName;

    public Item(string itemType, string quality, string itemName)
    {
        _itemType = itemType;
        _quality = quality;
        _itemName = itemName;
    }
}