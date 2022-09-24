namespace FactoryPattern.PizzaIngredient.Ingredients;

public interface IClams
{
    string Name { get; }
}

public class FreshClams : IClams
{
    public string Name => "Fresh Clams";
}

public class FrozenClams : IClams
{
    public string Name => "Frozen Clams";
}