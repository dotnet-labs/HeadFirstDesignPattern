using CompoundPattern.Observable;

namespace CompoundPattern.SomeGeese;

public class GooseAdapter : IQuackable
{
    private readonly Goose _goose;
    private readonly IQuackObservable _observable;

    public GooseAdapter(Goose goose)
    {
        _goose = goose;
        _observable = new QuackObservable(this);
    }

    public void Quack()
    {
        _goose.Honk();
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
        return "Goose";
    }
}