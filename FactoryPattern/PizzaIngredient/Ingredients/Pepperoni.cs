namespace FactoryPattern.PizzaIngredient.Ingredients;

public interface IPepperoni
{
    string Name { get; }
}

public class SlicedPepperoni : IPepperoni
{
    public string Name => "Sliced Pepperoni";
}