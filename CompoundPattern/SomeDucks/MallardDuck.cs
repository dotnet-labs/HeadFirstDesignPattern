using CompoundPattern.Observable;

namespace CompoundPattern.SomeDucks;

public class MallardDuck : IQuackable
{
    private readonly IQuackObservable _observable;

    public MallardDuck()
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
        return "MallardDuck";
    }
}