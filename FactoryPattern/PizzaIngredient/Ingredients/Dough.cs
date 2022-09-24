namespace FactoryPattern.PizzaIngredient.Ingredients;

public interface IDough
{
    string Name { get; }
}

public class ThinCrustDough : IDough
{
    public string Name => "Thin Crust Dough";
}

public class ThickCrustDough : IDough
{
    public string Name => "Thick Crust Dough";
}