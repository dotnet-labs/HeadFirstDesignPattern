using DecoratorPattern.Coffee.Beverages;

namespace DecoratorPattern.Coffee.Sizes;

public class Tall(Beverage beverage) : SizeDecorator(beverage)
{
    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Tall";
    }

    public override decimal Cost()
    {
        return Beverage.Cost() + 0.10m;
    }
}