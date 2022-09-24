namespace FactoryPattern.PizzaIngredient.Ingredients;

public interface ISauce
{
    string Name { get; }
}

public class MarinaraSauce : ISauce
{
    public string Name => "Marinara Sauce";
}

public class PlumTomatoSauce : ISauce
{
    public string Name => "Plum Tomato Sauce";
}