using CompoundPattern.Observable;

namespace CompoundPattern.Flock
{
    public class Flock : IQuackable
    {
        private readonly List<IQuackable> _quackers = new();

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
