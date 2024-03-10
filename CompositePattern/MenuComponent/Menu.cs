namespace CompositePattern.MenuComponent;

public class Menu(string description, string name) : IMenuComponent
{
    public string Name { get; } = name;
    public string Description { get; } = description;
    private readonly List<IMenuComponent> _menuComponents = new();


    public void Add(IMenuComponent menuComponent)
    {
        _menuComponents.Add(menuComponent);
    }

    public void Remove(IMenuComponent menuComponent)
    {
        _menuComponents.Remove(menuComponent);
    }

    public IMenuComponent GetChild(int i)
    {
        return _menuComponents[i];
    }

    public void Print()
    {
        Console.WriteLine("\n" + Name + ", " + Description);
        Console.WriteLine("-----------------------------");
        using var iterator = _menuComponents.GetEnumerator();
        while (iterator.MoveNext())
        {
            iterator.Current?.Print();
        }
    }
}