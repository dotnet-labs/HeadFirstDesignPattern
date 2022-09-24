using DecoratorPattern.Coffee.Beverages;

namespace DecoratorPattern.Coffee.Sizes;

public class Venti : SizeDecorator
{
    public Venti(Beverage beverage) : base(beverage)
    {
    }

    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Venti";
    }

    public override decimal Cost()
    {
        return Beverage.Cost() + 0.20m;
    }
}