using FactoryPattern.PizzaIngredient.Ingredients;
using System.Collections.Generic;

namespace FactoryPattern.PizzaIngredient
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new Mozzarella();
        }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie>
            {
                new BlackOlives(),
                new EggPlant(),
                new Spinach()
            };
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }
    }
}
