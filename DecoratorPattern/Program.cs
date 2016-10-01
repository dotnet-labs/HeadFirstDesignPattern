using DecoratorPattern.Coffee.Beverages;
using DecoratorPattern.Coffee.Condiments;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee();
            Console.ReadKey();
        }

        private static void Coffee()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Soy(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

            Beverage beverage3 = new DarkRoast();
            beverage3 = new Mocha(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());
        }
    }
}
