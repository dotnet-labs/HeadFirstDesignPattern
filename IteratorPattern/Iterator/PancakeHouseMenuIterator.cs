using IteratorPattern.Menu;

namespace IteratorPattern.Iterator;

internal class PancakeHouseMenuIterator : IIterator
{
    private readonly List<MenuItem> _menuItems;
    private int _index;

    public PancakeHouseMenuIterator(List<MenuItem> menuItems)
    {
        _menuItems = menuItems;
        _index = 0;
    }

    public bool HasNext()
    {
        return _index + 1 <= _menuItems.Count;
    }

    public object Next()
    {
        var menuItem = _menuItems[_index];
        _index++;
        return menuItem;
    }
}