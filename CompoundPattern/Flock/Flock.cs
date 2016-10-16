using CompoundPattern.Observable;
using System.Collections.Generic;

namespace CompoundPattern.Flock
{
    public class Flock : IQuackable
    {
        private readonly List<IQuackable> _quackers;
        private readonly IQuackObservable _observable;

        public Flock()
        {
            _quackers = new List<IQuackable>();
            _observable = new QuackObservable(this);
        }

        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }

        public void Quack()
        {
            foreach (var quacker in _quackers)
            {
                quacker.Quack();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            foreach (var quacker in _quackers)
            {
                quacker.RegisterObserver(observer);
            }
        }

        public void NotifyObservers()
        {
        }
    }
}
