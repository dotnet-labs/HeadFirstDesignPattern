using StatePattern.GumballMachines;

namespace StatePattern.States;

public class HasQuarterState(GumballMachine gumballMachine) : IState
{
    private readonly Random _randomWinner = new();

    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert another quarter.");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Quarter returned.");
        gumballMachine.SetState(gumballMachine.GetNoQuarterState());
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned...");
        var winner = _randomWinner.Next(10);
        if (winner == 0 && gumballMachine.Count > 1)
        {
            gumballMachine.SetState(gumballMachine.GetWinnerState());
        }
        else
        {
            gumballMachine.SetState(gumballMachine.GetSoldState());
        }
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed.");
    }
}