using CompoundPattern;
using CompoundPattern.DuckFactory;

var simulator = new DuckSimulator();
simulator.Simulate();
simulator.SimulateWithCounter();
simulator.SimulateUsingFactory(new CountingDuckFactory());
simulator.SimulateFlock(new CountingDuckFactory());
simulator.SimulateFlockWithObserver(new CountingDuckFactory());
Console.ReadKey();
