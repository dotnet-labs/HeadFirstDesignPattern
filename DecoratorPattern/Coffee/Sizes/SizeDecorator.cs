using DecoratorPattern.Coffee.Beverages;

namespace DecoratorPattern.Coffee.Sizes;

public abstract class SizeDecorator(Beverage beverage) : Beverage
{
    protected Beverage Beverage = beverage;
}