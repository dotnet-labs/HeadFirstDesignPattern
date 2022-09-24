using FactoryPattern.PizzaIngredient;
using FactoryPattern.PizzaProduct;

namespace FactoryPattern.PizzaStore;

public class ChicagoStylePizzaStore : PizzaStore
{
    private readonly ChicagoPizzaIngredientFactory _ingredientFactory;
    public ChicagoStylePizzaStore()
    {
        _ingredientFactory = new ChicagoPizzaIngredientFactory();
    }

    protected override Pizza? CreatePizza(PizzaType type)
    {
        Pizza pizza;

        switch (type)
        {
            case PizzaType.Cheese:
                pizza = new CheesePizza(_ingredientFactory);
                pizza.SetName("Chicago Style Cheese Pizza");
                break;
            case PizzaType.Pepperoni:
                pizza = new PepperoniPizza(_ingredientFactory);
                pizza.SetName("Chicago Style Pepperoni Pizza");
                break;
            case PizzaType.Clam:
                pizza = new ClamPizza(_ingredientFactory);
                pizza.SetName("Chicago Style Clam Pizza");
                break;
            case PizzaType.Veggie:
                pizza = new VeggiePizza(_ingredientFactory);
                pizza.SetName("Chicago Style Veggie Pizza");
                break;
            default:
                return null;
        }

        return pizza;
    }
}