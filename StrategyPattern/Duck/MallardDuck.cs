namespace StrategyPattern.Duck;

public class MallardDuck() : Duck(new FlyWithWings(), new CanQuack())
{
    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
}