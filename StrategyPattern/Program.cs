using StrategyPattern.Duck;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
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
