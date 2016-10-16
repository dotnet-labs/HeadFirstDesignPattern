using CompoundPattern.DuckFactory;
using System;

namespace CompoundPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var simulator = new DuckSimulator();
            simulator.Simulate();
            simulator.SimulateWithCounter();
            simulator.SimulateUsingFactory(new CountingDuckFactory());
            simulator.SimulateFlock(new CountingDuckFactory());
            simulator.SimulateFlockWithObserver(new CountingDuckFactory());
            Console.ReadKey();
        }
    }
}
