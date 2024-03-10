using System.Text;

namespace CompositePattern.MenuComponent;

public class MenuItem(string name, string description, bool isVegetarian, decimal price)
    : IMenuComponent
{
    public string Name { get; } = name;
    public string Description { get; } = description;
    public bool IsVegetarian { get; } = isVegetarian;
    public decimal Price { get; } = price;

    public void Add(IMenuComponent menuComponent)
    {
        throw new NotImplementedException();
    }

    public void Remove(IMenuComponent menuComponent)
    {
        throw new NotImplementedException();
    }

    public IMenuComponent GetChild(int i)
    {
        throw new NotImplementedException();
    }

    public void Print()
    {
        var sb = new StringBuilder();
        sb.Append("  " + Name);
        sb.Append(IsVegetarian ? "(v)" : "");
        sb.Append(Price);
        sb.Append("\t--- " + Description);
        Console.WriteLine(sb.ToString());
    }
}