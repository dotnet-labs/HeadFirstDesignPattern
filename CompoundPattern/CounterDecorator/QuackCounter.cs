namespace CompoundPattern.CounterDecorator
{
    public class QuackCounter : IQuackable
    {
        private readonly IQuackable _duck;
        private static int _totalNumberOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
        }

        public void Quack()
        {
            _duck.Quack();
            _totalNumberOfQuacks++;
        }

        public static int GetQuacksCount()
        {
            return _totalNumberOfQuacks;
        }
    }
}
