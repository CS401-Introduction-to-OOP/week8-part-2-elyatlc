namespace Week8;

public class DataContainer<T> where T: DataItem
{
    private readonly List<T> _items = new();
    
    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public long GetTotalSize()
    {
        long totalSize = 0;
        foreach (var item in _items)
        {
            totalSize+= item.GetSize();
        }
        return totalSize;
    }
    
}