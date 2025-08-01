namespace ClassLibrary1;

public class Class1
{
    public List<string> _items;

    public Class1()
    {
        _items = new List<string>();
    }

    public void AddItem(string item)
    {
        _items.Add(item);
    }

    public bool RemoveItem(string item)
    {
        return _items.Remove(item);
    }

    public List<string> GetItems()
    {
        return new List<string>(_items);
    }
}
