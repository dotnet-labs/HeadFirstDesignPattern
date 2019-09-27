using FactoryPattern.PizzaProduct;
using FactoryPattern.PizzaStore;
using System;

namespace FactoryPattern
{
    internal class Program
    {
        private static void Main()
        {
            PizzaTestDrive();
            Console.ReadKey();
        }

        private static void PizzaTestDrive()
        {
            var nyStore = new NyStylePizzaStore();
            var pizza = nyStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"You ordered a {pizza.Name}\n");

            var chicagoStore = new ChicagoStylePizzaStore();
            pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"You ordered a {pizza.Name}\n");
        }
    }
}
