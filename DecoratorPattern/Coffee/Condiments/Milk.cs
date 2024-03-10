using DecoratorPattern.Coffee.Beverages;

namespace DecoratorPattern.Coffee.Condiments;

public class Milk(Beverage beverage) : CondimentDecorator(beverage)
{
    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Milk";
    }

    public override decimal Cost()
    {
        return Beverage.Cost() + 0.10m;
    }
}