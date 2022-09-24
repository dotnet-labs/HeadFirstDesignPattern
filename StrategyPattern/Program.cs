using StrategyPattern.Duck;

var mallard = new MallardDuck();
mallard.Display();
mallard.PerformFly();
mallard.PerformQuack();

var model = new ModelDuck();
model.Display();
model.PerformFly();
model.PerformQuack();
Console.WriteLine("---------\r\n>>> powered by rocket.");
model.SetFlyBehavior(new FlyRocketPowered());
model.PerformFly();

Console.ReadKey();