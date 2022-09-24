using DecoratorPattern.Coffee.Beverages;

namespace DecoratorPattern.Coffee.Sizes;

public class Grande : SizeDecorator
{
    public Grande(Beverage beverage) : base(beverage)
    {
    }

    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Grande";
    }

    public override decimal Cost()
    {
        return Beverage.Cost() + 0.15m;
    }
}