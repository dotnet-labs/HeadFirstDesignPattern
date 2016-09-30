using System;

namespace StrategyPattern.Duck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeak();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
