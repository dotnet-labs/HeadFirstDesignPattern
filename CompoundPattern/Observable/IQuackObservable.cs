namespace CompoundPattern.Observable;

public interface IQuackObservable
{
    void RegisterObserver(IObserver observer);
    void NotifyObservers();
}