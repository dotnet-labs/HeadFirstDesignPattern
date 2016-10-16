using CompoundPattern.Observable;

namespace CompoundPattern
{
    public interface IQuackable : IQuackObservable
    {
        void Quack();
    }
}
