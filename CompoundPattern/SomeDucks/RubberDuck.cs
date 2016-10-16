using System;

namespace CompoundPattern.SomeDucks
{
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak.");
        }
    }
}
