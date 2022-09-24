using IteratorPattern.Menu;

namespace IteratorPattern.Iterator;

public class DinnerMenuIterator : IIterator
{
    private readonly MenuItem[] _items;
    private int _index;

    public DinnerMenuIterator(MenuItem[] items)
    {
        _items = items;
        _index = 0;
    }

    public bool HasNext()
    {
        return _index < _items.Length;
    }

    public object Next()
    {
        var menuItem = _items[_index];
        _index++;
        return menuItem;
    }
}