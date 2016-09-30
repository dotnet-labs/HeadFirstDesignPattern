using System;

namespace StrategyPattern.Duck
{
    public class CanQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Quack.");
        }
    }

    public class MuteQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }

    public class Squeak : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
