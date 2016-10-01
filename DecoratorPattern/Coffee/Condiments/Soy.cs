using DecoratorPattern.Coffee.Beverages;

namespace DecoratorPattern.Coffee.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Soy";
        }

        public override decimal Cost()
        {
            return Beverage.Cost() + 0.15m;
        }
    }
}
