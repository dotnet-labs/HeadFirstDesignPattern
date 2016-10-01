using DecoratorPattern.Coffee.Beverages;

namespace DecoratorPattern.Coffee.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage;

    }
}
