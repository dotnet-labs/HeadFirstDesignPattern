namespace IteratorPattern.Menu;

public class MenuItem
{
    public string Name { get; }
    public string Description { get; }
    public bool IsVegetarian { get; }
    public decimal Price { get; }

    public MenuItem(string name, string description, bool isVegetarian, decimal price)
    {
        Name = name;
        Description = description;
        IsVegetarian = isVegetarian;
        Price = price;
    }
}