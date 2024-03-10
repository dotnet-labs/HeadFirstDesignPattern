using IteratorPattern.Menu;

namespace IteratorPattern.Iterator;

public class DinnerMenuIterator(MenuItem[] items) : IIterator
{
    private int _index = 0;

    public bool HasNext()
    {
        return _index < items.Length;
    }

    public object Next()
    {
        var menuItem = items[_index];
        _index++;
        return menuItem;
    }
}