namespace CompoundPattern.Observable;

public class QuackObservable(IQuackObservable duck) : IQuackObservable
{
    private readonly List<IObserver> _observers = new();

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(duck);
        }
    }
}