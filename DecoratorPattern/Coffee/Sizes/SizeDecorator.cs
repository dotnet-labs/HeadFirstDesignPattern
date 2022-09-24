using DecoratorPattern.Coffee.Beverages;

namespace DecoratorPattern.Coffee.Sizes;

public abstract class SizeDecorator : Beverage
{
    protected Beverage Beverage;

    protected SizeDecorator(Beverage beverage)
    {
        Beverage = beverage;
    }
}