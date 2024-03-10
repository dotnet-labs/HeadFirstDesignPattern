using StatePattern.GumballMachines;

namespace StatePattern.States;

public class WinnerState(GumballMachine gumballMachine) : IState
{
    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a gumball.");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Sorry, you already turned the crank.");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Turning twice doesn't get you another gumball.");
    }

    public void Dispense()
    {
        Console.WriteLine("You are a WINNER! You get two gumballs for your quarter.");
        gumballMachine.ReleaseBall();
        if (gumballMachine.Count > 0)
        {
            gumballMachine.ReleaseBall();
            if (gumballMachine.Count > 0)
            {
                gumballMachine.SetState(gumballMachine.GetNoQuarterState());
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.SetState(gumballMachine.GetSoldOutState());

            }
        }
        else
        {
            gumballMachine.SetState(gumballMachine.GetSoldOutState());
        }
    }
}