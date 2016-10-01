using FactoryPattern.PizzaProduct;
using FactoryPattern.PizzaStore;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaTestDrive();
            Console.ReadKey();
        }

        private static void PizzaTestDrive()
        {
            var nyStore = new NYStylePizzaStore();
            var pizza = nyStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"You ordered a {pizza.Name}\n");

            var chicagoStore = new ChicagoStylePizzaStore();
            pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"You ordered a {pizza.Name}\n");
        }
    }
}
