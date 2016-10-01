using FactoryPattern.PizzaProduct;

namespace FactoryPattern.PizzaStore
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new ChicagoStyleCheesePizza();
                case PizzaType.Pepperoni:
                    return new ChicagoStylePepperoniPizza();
                case PizzaType.Clam:
                    return new ChicagoStyleClamPizza();
                case PizzaType.Veggie:
                    return new ChicagoStyleVeggiePizza();
                default:
                    return null;
            }
        }
    }
}
