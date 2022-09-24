using CompoundPattern.Observable;

namespace CompoundPattern.SomeDucks;

public class DuckCall : IQuackable
{
    private readonly IQuackObservable _observable;

    public DuckCall()
    {
        _observable = new QuackObservable(this);
    }

    public void Quack()
    {
        Console.WriteLine("Kwak.");
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
        return "DuckCall";
    }
}