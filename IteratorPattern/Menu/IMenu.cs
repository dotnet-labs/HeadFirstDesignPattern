using IteratorPattern.Iterator;

namespace IteratorPattern.Menu;

public interface IMenu
{
    IIterator CreateIterator();
}