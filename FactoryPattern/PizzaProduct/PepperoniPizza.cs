using FactoryPattern.PizzaIngredient;

namespace FactoryPattern.PizzaProduct;

public class PepperoniPizza : Pizza
{
    public PepperoniPizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Dough = IngredientFactory.CreateDough();
        Sauce = IngredientFactory.CreateSauce();
        Cheese = IngredientFactory.CreateCheese();
        Pepperoni = IngredientFactory.CreatePepperoni();
    }
}