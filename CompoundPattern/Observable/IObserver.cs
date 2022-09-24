namespace CompoundPattern.Observable;

public interface IObserver
{
    void Update(IQuackObservable duck);
}