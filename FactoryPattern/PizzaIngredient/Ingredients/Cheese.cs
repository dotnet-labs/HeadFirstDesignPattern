namespace FactoryPattern.PizzaIngredient.Ingredients
{
    public interface ICheese
    {
        string Name { get; }
    }

    public class ReggianoCheese : ICheese
    {
        public string Name => "Reggiano Cheese";
    }

    public class Mozzarella : ICheese
    {
        public string Name => "Mozzarella Cheese";
    }
}