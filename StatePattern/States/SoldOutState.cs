using StatePattern.GumballMachines;

namespace StatePattern.States;

public class SoldOutState(GumballMachine gumballMachine) : IState
{
    private readonly GumballMachine _gumballMachine = gumballMachine;

    public void InsertQuarter()
    {
        Console.WriteLine("You cannot insert a quarter, the machine is sold out.");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You cannot eject, you haven't inserted a quarter yet.");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned, but there are no gumballs.");
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed.");
    }
}