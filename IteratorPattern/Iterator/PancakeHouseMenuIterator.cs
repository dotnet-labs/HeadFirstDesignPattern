using IteratorPattern.Menu;

namespace IteratorPattern.Iterator;

internal class PancakeHouseMenuIterator(List<MenuItem> menuItems) : IIterator
{
    private int _index = 0;

    public bool HasNext()
    {
        return _index + 1 <= menuItems.Count;
    }

    public object Next()
    {
        var menuItem = menuItems[_index];
        _index++;
        return menuItem;
    }
}