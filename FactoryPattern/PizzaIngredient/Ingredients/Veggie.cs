namespace FactoryPattern.PizzaIngredient.Ingredients;

public interface IVeggie
{
    string Name { get; }
}

public class Garlic : IVeggie
{
    public string Name => "Garlic";
}

public class Onion : IVeggie
{
    public string Name => "Onion";
}

public class Mushroom : IVeggie
{
    public string Name => "Mushroom";
}

public class RedPepper : IVeggie
{
    public string Name => "Red Pepper";
}

public class Spinach : IVeggie
{
    public string Name => "Spinach";
}

public class BlackOlives : IVeggie
{
    public string Name => "Black Olives";
}

public class EggPlant : IVeggie
{
    public string Name => "Eggplant";
}