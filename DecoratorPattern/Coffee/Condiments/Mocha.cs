using DecoratorPattern.Coffee.Beverages;

namespace DecoratorPattern.Coffee.Condiments;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage) : base(beverage)
    {
    }

    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Mocha";
    }

    public override decimal Cost()
    {
        return 0.20m + Beverage.Cost();
    }
}