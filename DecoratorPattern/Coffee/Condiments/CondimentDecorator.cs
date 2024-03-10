using DecoratorPattern.Coffee.Beverages;

namespace DecoratorPattern.Coffee.Condiments;

public abstract class CondimentDecorator(Beverage beverage) : Beverage
{
    protected Beverage Beverage = beverage;
}