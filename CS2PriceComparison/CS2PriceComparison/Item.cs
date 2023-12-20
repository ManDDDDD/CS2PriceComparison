namespace CS2PriceComparison;

public class Item
{
    private string _itemType;
    private string _itemQuality;
    private string _itemName;

    public Item(string itemType, string itemQuality, string itemName)
    {
        _itemType = itemType;
        _itemQuality = itemQuality;
        _itemName = itemName;
    }
    
    public string? itemType
    {
        get { return _itemType; }
    }
    public string? itemQuality
    {
        get { return _itemQuality; }
    }
    public string? itemName
    {
        get { return _itemName; }
    }

}