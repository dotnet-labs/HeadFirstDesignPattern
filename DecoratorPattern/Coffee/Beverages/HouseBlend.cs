namespace DecoratorPattern.Coffee.Beverages;

public class HouseBlend : Beverage
{
    public override string GetDescription()
    {
        return "House Blend Coffee";
    }

    public override decimal Cost()
    {
        return 0.89m;
    }
}