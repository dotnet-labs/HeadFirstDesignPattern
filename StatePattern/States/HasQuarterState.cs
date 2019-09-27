using StatePattern.GumballMachines;
using System;

namespace StatePattern.States
{
    public class HasQuarterState : IState
    {
        private readonly Random _randomWinner = new Random();
        private readonly GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned.");
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            var winner = _randomWinner.Next(10);
            if (winner == 0 && _gumballMachine.Count > 1)
            {
                _gumballMachine.SetState(_gumballMachine.GetWinnerState());
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.GetSoldState());
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed.");
        }
    }
}
