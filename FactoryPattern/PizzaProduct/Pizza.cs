using FactoryPattern.PizzaIngredient;
using FactoryPattern.PizzaIngredient.Ingredients;
using System;
using System.Collections.Generic;

namespace FactoryPattern.PizzaProduct
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public IDough Dough { get; protected set; }
        public ISauce Sauce { get; protected set; }
        public List<IVeggie> Veggies { get; protected set; }
        public ICheese Cheese { get; protected set; }
        public IPepperoni Pepperoni { get; protected set; }
        public IClams Clams { get; protected set; }
        protected readonly IPizzaIngredientFactory IngredientFactory;

        protected Pizza(IPizzaIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
        }

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 degree");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices.");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box.");
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
