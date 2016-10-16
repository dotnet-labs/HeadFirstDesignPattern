using System.Collections.Generic;

namespace CompoundPattern.Observable
{
    public class QuackObservable : IQuackObservable
    {
        private readonly List<IObserver> _observers;
        private readonly IQuackObservable _duck;

        public QuackObservable(IQuackObservable duck)
        {
            _observers = new List<IObserver>();
            _duck = duck;
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_duck);
            }
        }
    }
}
