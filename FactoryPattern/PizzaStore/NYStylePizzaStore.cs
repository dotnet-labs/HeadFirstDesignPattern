using FactoryPattern.PizzaIngredient;
using FactoryPattern.PizzaProduct;

namespace FactoryPattern.PizzaStore
{
    public class NyStylePizzaStore : PizzaStore
    {
        private readonly NYPizzaIngredientFactory _ingredientFactory;
        public NyStylePizzaStore()
        {
            _ingredientFactory = new NYPizzaIngredientFactory();
        }

        protected override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza;

            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza(_ingredientFactory);
                    pizza.SetName("New York Style Cheese Pizza");
                    break;
                case PizzaType.Pepperoni:
                    pizza = new PepperoniPizza(_ingredientFactory);
                    pizza.SetName("New York Style Pepperoni Pizza");
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza(_ingredientFactory);
                    pizza.SetName("New York Style Clam Pizza");
                    break;
                case PizzaType.Veggie:
                    pizza = new VeggiePizza(_ingredientFactory);
                    pizza.SetName("New York Style Veggie Pizza");
                    break;
                default:
                    return null;
            }

            return pizza;
        }


    }
}
