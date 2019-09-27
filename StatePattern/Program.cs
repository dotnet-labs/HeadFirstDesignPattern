using StatePattern.GumballMachines;
using System;

namespace StatePattern
{
    internal class Program
    {
        private static void Main()
        {
            GumballMachineTestDrive();
            Console.ReadKey();
        }

        private static void GumballMachineTestDrive()
        {
            var gumballMachine = new GumballMachine(5);
            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);
        }
    }
}
