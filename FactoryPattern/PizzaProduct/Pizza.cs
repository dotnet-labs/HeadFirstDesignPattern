using System;
using System.Collections.Generic;

namespace FactoryPattern.PizzaProduct
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        public List<Topping> Toppings { get; protected set; }

        protected Pizza()
        {
            Toppings = new List<Topping>();
        }

        public void AddTopping(Topping topping)
        {
            Toppings.Add(topping);
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine($"Adding toppings:");
            foreach (var topping in Toppings)
            {
                Console.WriteLine($"\t{topping.Name}");
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 degree");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices.");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box.");
        }
    }
}
