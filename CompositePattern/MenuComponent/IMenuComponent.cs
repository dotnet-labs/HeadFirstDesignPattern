namespace CompositePattern.MenuComponent;

public interface IMenuComponent
{
    void Add(IMenuComponent menuComponent);
    void Remove(IMenuComponent menuComponent);
    IMenuComponent GetChild(int i);
    void Print();
}