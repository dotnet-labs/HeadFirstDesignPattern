namespace CompositePattern.MenuComponent;

public class Menu : IMenuComponent
{
    public string Name { get; }
    public string Description { get; }
    private readonly List<IMenuComponent> _menuComponents;

    public Menu(string description, string name)
    {
        Description = description;
        Name = name;
        _menuComponents = new List<IMenuComponent>();
    }


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