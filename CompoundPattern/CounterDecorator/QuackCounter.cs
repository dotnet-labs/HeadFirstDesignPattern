using CompoundPattern.Observable;

namespace CompoundPattern.CounterDecorator
{
    public class QuackCounter : IQuackable
    {
        private readonly IQuackable _duck;
        private static int _totalNumberOfQuacks;
        private readonly IQuackObservable _observable;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
            _observable = new QuackObservable(this);
        }

        public void Quack()
        {
            _duck.Quack();
            NotifyObservers();
            _totalNumberOfQuacks++;
        }

        public static int GetQuacksCount()
        {
            return _totalNumberOfQuacks;
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
            return _duck.ToString();
        }
    }
}
