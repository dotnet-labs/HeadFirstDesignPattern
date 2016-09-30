using System;

namespace StrategyPattern.Duck
{
    public abstract class Duck
    {
        protected IFly FlyBehavior;
        protected IQuack QuackBehavior;

        protected Duck()
        {

        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys.");
        }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void SetFlyBehavior(IFly fb)
        {
            FlyBehavior = fb;
        }

        public void SetQuackBehavior(IQuack qb)
        {
            QuackBehavior = qb;
        }
    }

}
