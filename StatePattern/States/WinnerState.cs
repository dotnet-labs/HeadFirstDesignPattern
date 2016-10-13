using StatePattern.GumballMachines;
using System;

namespace StatePattern.States
{
    public class WinnerState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

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
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.ReleaseBall();
                if (_gumballMachine.Count > 0)
                {
                    _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    _gumballMachine.SetState(_gumballMachine.GetSoldOutState());

                }
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
            }
        }
    }
}
