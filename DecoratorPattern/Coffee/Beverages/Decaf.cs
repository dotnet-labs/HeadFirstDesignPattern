namespace DecoratorPattern.Coffee.Beverages
{
    public class Decaf : Beverage
    {
        public override string GetDescription()
        {
            return "Decaf Coffee";
        }

        public override decimal Cost()
        {
            return 1.05m;
        }
    }
}
