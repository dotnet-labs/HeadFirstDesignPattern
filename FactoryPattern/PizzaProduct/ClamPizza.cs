using FactoryPattern.PizzaIngredient;
using System;

namespace FactoryPattern.PizzaProduct
{
    public class ClamPizza : Pizza
    {
        public ClamPizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = IngredientFactory.CreateDough();
            Sauce = IngredientFactory.CreateSauce();
            Cheese = IngredientFactory.CreateCheese();
            Clams = IngredientFactory.CreateClams();
        }
    }
}
