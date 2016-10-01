namespace DecoratorPattern.Coffee.Beverages
{
    public abstract class Beverage
    {
        public abstract string GetDescription();

        public abstract decimal Cost();
    }
}
