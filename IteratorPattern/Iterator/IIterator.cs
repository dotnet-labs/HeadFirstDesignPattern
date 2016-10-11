namespace IteratorPattern.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
