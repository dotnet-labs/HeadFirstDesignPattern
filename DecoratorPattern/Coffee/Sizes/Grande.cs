using DecoratorPattern.Coffee.Beverages;

namespace DecoratorPattern.Coffee.Sizes;

public class Grande(Beverage beverage) : SizeDecorator(beverage)
{
    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Grande";
    }

    public override decimal Cost()
    {
        return Beverage.Cost() + 0.15m;
    }
}