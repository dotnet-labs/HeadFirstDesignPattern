namespace DecoratorPattern.Coffee.Beverages;

public class DarkRoast : Beverage
{
    public override string GetDescription()
    {
        return "Dark Roast Coffee";
    }

    public override decimal Cost()
    {
        return 0.99m;
    }
}