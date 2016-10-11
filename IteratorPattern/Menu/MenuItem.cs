namespace IteratorPattern.Menu
{
    public class MenuItem
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsVegetarian { get; private set; }
        public decimal Price { get; private set; }

        public MenuItem(string name, string description, bool isVegetarian, decimal price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }
    }
}
