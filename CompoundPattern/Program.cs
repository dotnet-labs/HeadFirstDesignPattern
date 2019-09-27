using CompoundPattern.DuckFactory;
using System;

namespace CompoundPattern
{
    internal class Program
    {
        private static void Main()
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
