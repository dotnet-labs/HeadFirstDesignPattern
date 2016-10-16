using CompoundPattern.Observable;
using System;

namespace CompoundPattern.SomeDucks
{
    public class RubberDuck : IQuackable
    {
        private readonly IQuackObservable _observable;

        public RubberDuck()
        {
            _observable = new QuackObservable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Squeak.");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public override string ToString()
        {
            return "RubberDuck";
        }
    }
}
