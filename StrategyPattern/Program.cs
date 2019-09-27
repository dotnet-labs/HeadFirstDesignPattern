using StrategyPattern.Duck;
using System;

namespace StrategyPattern
{
    internal class Program
    {
        private static void Main()
        {
            MiniDuckSimulator();

            Console.ReadKey();

        }

        private static void MiniDuckSimulator()
        {
            var mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformFly();
            mallard.PerformQuack();

            var model = new ModelDuck();
            model.Display();
            model.PerformFly();
            model.PerformQuack();
            Console.WriteLine("---------\r\n>>> powered by rocket.");
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
