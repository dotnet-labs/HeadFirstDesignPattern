using FactoryPattern.PizzaIngredient;

namespace FactoryPattern.PizzaProduct;

public class ClamPizza(IPizzaIngredientFactory ingredientFactory) : Pizza(ingredientFactory)
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Dough = IngredientFactory.CreateDough();
        Sauce = IngredientFactory.CreateSauce();
        Cheese = IngredientFactory.CreateCheese();
        Clams = IngredientFactory.CreateClams();
    }
}