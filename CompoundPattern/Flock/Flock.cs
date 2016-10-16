using System.Collections.Generic;

namespace CompoundPattern.Flock
{
    public class Flock : IQuackable
    {
        private readonly List<IQuackable> _quackers;

        public Flock()
        {
            _quackers = new List<IQuackable>();
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
    }
}
