namespace IteratorPattern.Menu;

public class MenuItem(string name, string description, bool isVegetarian, decimal price)
{
    public string Name { get; } = name;
    public string Description { get; } = description;
    public bool IsVegetarian { get; } = isVegetarian;
    public decimal Price { get; } = price;
}