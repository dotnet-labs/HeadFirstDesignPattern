namespace CompoundPattern.DuckFactory;

public abstract class AbstractDuckFactory
{
    public abstract IQuackable CreateMallardDuck { get; }
    public abstract IQuackable CreateRedheadDuck { get; }
    public abstract IQuackable CreateDuckCall { get; }
    public abstract IQuackable CreateRubberDuck { get; }
}