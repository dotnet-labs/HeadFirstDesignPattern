using FactoryPattern.PizzaIngredient;
using FactoryPattern.PizzaIngredient.Ingredients;

namespace FactoryPattern.PizzaProduct;

public abstract class Pizza(IPizzaIngredientFactory ingredientFactory)
{
    public string Name { get; protected set; } = string.Empty;
    public IDough Dough { get; protected set; } = null!;
    public ISauce Sauce { get; protected set; } = null!;
    public List<IVeggie> Veggies { get; protected set; } = new();
    public ICheese Cheese { get; protected set; } = null!;
    public IPepperoni Pepperoni { get; protected set; } = null!;
    public IClams Clams { get; protected set; } = null!;
    protected readonly IPizzaIngredientFactory IngredientFactory = ingredientFactory;

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