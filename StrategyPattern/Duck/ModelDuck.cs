﻿namespace StrategyPattern.Duck;

public class ModelDuck() : Duck(new FlyNoWay(), new Squeak())
{
    public override void Display()
    {
        Console.WriteLine("I'm a model duck");
    }
}