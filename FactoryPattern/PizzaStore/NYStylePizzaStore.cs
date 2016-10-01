using FactoryPattern.PizzaProduct;

namespace FactoryPattern.PizzaStore
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new NYStyleCheesePizza();
                case PizzaType.Pepperoni:
                    return new NYStylePepperoniPizza();
                case PizzaType.Clam:
                    return new NYStyleClamPizza();
                case PizzaType.Veggie:
                    return new NYStyleVeggiePizza();
                default:
                    return null;
            }
        }
    }
}
