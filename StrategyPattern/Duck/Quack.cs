namespace StrategyPattern.Duck;

public interface IQuack
{
    void Quack();
}

public class CanQuack : IQuack
{
    public void Quack()
    {
        Console.WriteLine("Quack.");
    }
}

public class MuteQuack : IQuack
{
    public void Quack()
    {
        Console.WriteLine("<<Silence>>");
    }
}

public class Squeak : IQuack
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}