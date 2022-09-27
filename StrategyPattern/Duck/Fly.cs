﻿namespace StrategyPattern.Duck;

public interface IFly
{
    void Fly();
}

public class FlyWithWings : IFly
{
    public void Fly()
    {
        Console.WriteLine("I'm flying.");
    }
}

public class FlyNoWay : IFly
{
    public void Fly()
    {
        Console.WriteLine("I can't fly.");
    }
}

public class FlyRocketPowered : IFly
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with a rocket.");
    }
}