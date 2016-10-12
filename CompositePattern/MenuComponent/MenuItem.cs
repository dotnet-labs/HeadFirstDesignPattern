using System;
using System.Text;

namespace CompositePattern.MenuComponent
{
    public class MenuItem : IMenuComponent
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
}
