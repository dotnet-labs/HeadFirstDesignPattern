using CompoundPattern.Observable;
using System;

namespace CompoundPattern.SomeDucks
{
    public class RedheadDuck : IQuackable
    {
        private readonly IQuackObservable _observable;

        public RedheadDuck()
        {
            _observable = new QuackObservable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack.");
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
            return "Redhead Duck";
        }
    }
}
