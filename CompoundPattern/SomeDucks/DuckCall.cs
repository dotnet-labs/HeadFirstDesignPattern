using System;

namespace CompoundPattern.SomeDucks
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak.");
        }
    }
}
