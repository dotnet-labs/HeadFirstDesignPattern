using CompoundPattern.CounterDecorator;
using CompoundPattern.DuckFactory;
using CompoundPattern.Observable;
using CompoundPattern.SomeDucks;
using CompoundPattern.SomeGeese;

namespace CompoundPattern;

public class DuckSimulator
{
    public void Simulate()
    {
        var mallardDuck = new MallardDuck();
        var redheadDuck = new RedheadDuck();
        var duckCall = new DuckCall();
        var rubberDuck = new RubberDuck();
        var gooseDuck = new GooseAdapter(new Goose());

        Console.WriteLine("\nDuck Simulator");
        Simulate(mallardDuck);
        Simulate(redheadDuck);
        Simulate(duckCall);
        Simulate(rubberDuck);
        Simulate(gooseDuck);
    }

    public void SimulateWithCounter()
    {
        var mallardDuck = new QuackCounter(new MallardDuck());
        var redheadDuck = new QuackCounter(new RedheadDuck());
        var duckCall = new QuackCounter(new DuckCall());
        var rubberDuck = new QuackCounter(new RubberDuck());
        var gooseDuck = new GooseAdapter(new Goose());

        Console.WriteLine("\nDuck Simulator: With Decorator");
        Simulate(mallardDuck);
        Simulate(redheadDuck);
        Simulate(duckCall);
        Simulate(rubberDuck);
        Simulate(gooseDuck);

        Console.WriteLine($"The ducks quacked {QuackCounter.GetQuacksCount()} times.");
    }

    public void SimulateUsingFactory(AbstractDuckFactory duckFactory)
    {
        var mallardDuck = duckFactory.CreateMallardDuck;
        var redheadDuck = duckFactory.CreateRedheadDuck;
        var duckCall = duckFactory.CreateDuckCall;
        var rubberDuck = duckFactory.CreateRubberDuck;
        var gooseDuck = new GooseAdapter(new Goose());

        Console.WriteLine("\nDuck Simulator: With Abstract Factory");
        Simulate(mallardDuck);
        Simulate(redheadDuck);
        Simulate(duckCall);
        Simulate(rubberDuck);
        Simulate(gooseDuck);

        Console.WriteLine($"The ducks quacked {QuackCounter.GetQuacksCount()} times.");
    }

    public void SimulateFlock(AbstractDuckFactory duckFactory)
    {
        var mallardDuck = duckFactory.CreateMallardDuck;
        var redheadDuck = duckFactory.CreateRedheadDuck;
        var duckCall = duckFactory.CreateDuckCall;
        var rubberDuck = duckFactory.CreateRubberDuck;
        var gooseDuck = new GooseAdapter(new Goose());

        Console.WriteLine("\nDuck Simulator: With Composite - Flocks");

        var flockOfDucks = new Flock.Flock();
        flockOfDucks.Add(mallardDuck);
        flockOfDucks.Add(redheadDuck);
        flockOfDucks.Add(duckCall);
        flockOfDucks.Add(rubberDuck);
        flockOfDucks.Add(gooseDuck);

        var flockOfMallardDucks = new Flock.Flock();
        var mallard1 = duckFactory.CreateMallardDuck;
        var mallard2 = duckFactory.CreateMallardDuck;
        var mallard3 = duckFactory.CreateMallardDuck;
        var mallard4 = duckFactory.CreateMallardDuck;
        flockOfMallardDucks.Add(mallard1);
        flockOfMallardDucks.Add(mallard2);
        flockOfMallardDucks.Add(mallard3);
        flockOfMallardDucks.Add(mallard4);
        flockOfDucks.Add(flockOfMallardDucks);

        Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
        Simulate(flockOfDucks);
        Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
        Simulate(flockOfMallardDucks);

        Console.WriteLine($"The ducks quacked {QuackCounter.GetQuacksCount()} times.");
    }

    public void SimulateFlockWithObserver(AbstractDuckFactory duckFactory)
    {
        var mallardDuck = duckFactory.CreateMallardDuck;
        var redheadDuck = duckFactory.CreateRedheadDuck;
        var duckCall = duckFactory.CreateDuckCall;
        var rubberDuck = duckFactory.CreateRubberDuck;
        var gooseDuck = new GooseAdapter(new Goose());

        Console.WriteLine("\nDuck Simulator: With Observer");

        var flockOfDucks = new Flock.Flock();
        flockOfDucks.Add(mallardDuck);
        flockOfDucks.Add(redheadDuck);
        flockOfDucks.Add(duckCall);
        flockOfDucks.Add(rubberDuck);
        flockOfDucks.Add(gooseDuck);

        var flockOfMallardDucks = new Flock.Flock();
        var mallard1 = duckFactory.CreateMallardDuck;
        var mallard2 = duckFactory.CreateMallardDuck;
        var mallard3 = duckFactory.CreateMallardDuck;
        var mallard4 = duckFactory.CreateMallardDuck;
        flockOfMallardDucks.Add(mallard1);
        flockOfMallardDucks.Add(mallard2);
        flockOfMallardDucks.Add(mallard3);
        flockOfMallardDucks.Add(mallard4);
        flockOfDucks.Add(flockOfMallardDucks);

        var quackologist = new Quackologist();
        flockOfDucks.RegisterObserver(quackologist);
        Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
        Simulate(flockOfDucks);
        Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
        Simulate(flockOfMallardDucks);

        Console.WriteLine($"The ducks quacked {QuackCounter.GetQuacksCount()} times.");
    }

    private void Simulate(IQuackable duck)
    {
        duck.Quack();
    }
}