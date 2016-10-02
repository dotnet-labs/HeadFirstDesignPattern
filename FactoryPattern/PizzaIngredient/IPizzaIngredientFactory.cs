using FactoryPattern.PizzaIngredient.Ingredients;
using System.Collections.Generic;

namespace FactoryPattern.PizzaIngredient
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        List<IVeggie> CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClams();
    }
}
