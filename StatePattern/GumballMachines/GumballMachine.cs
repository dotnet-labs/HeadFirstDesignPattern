using StatePattern.States;
using System.Text;

namespace StatePattern.GumballMachines;

public class GumballMachine
{
    private readonly IState _soldOutState;
    private readonly IState _noQuarterState;
    private readonly IState _hasQuarterState;
    private readonly IState _soldState;
    private readonly IState _winnerState;
    private IState _state = null!;
    public int Count { get; private set; }

    public GumballMachine(int numberOfGumballs)
    {
        _soldOutState = new SoldOutState(this);
        _noQuarterState = new NoQuarterState(this);
        _hasQuarterState = new HasQuarterState(this);
        _soldState = new SoldState(this);
        _winnerState = new WinnerState(this);
        Count = numberOfGumballs;
        if (numberOfGumballs > 0)
        {
            _state = _noQuarterState;
        }
    }

    public void SetState(IState state)
    {
        _state = state;
    }

    public IState GetHasQuarterState()
    {
        return _hasQuarterState;
    }

    public IState GetSoldOutState()
    {
        return _soldOutState;
    }

    public IState GetSoldState()
    {
        return _soldState;
    }

    public IState GetNoQuarterState()
    {
        return _noQuarterState;
    }

    public IState GetWinnerState()
    {
        return _winnerState;
    }

    public void InsertQuarter()
    {
        _state.InsertQuarter();
    }

    public void EjectQuarter()
    {
        _state.EjectQuarter();
    }

    public void TurnCrank()
    {
        _state.TurnCrank();
        _state.Dispense();
    }

    public void ReleaseBall()
    {
        Console.WriteLine("A gumball comes rolling out the slot...");
        if (Count != 0)
        {
            Count--;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("\nMighty Gumball, Inc.");
        sb.AppendLine($"Inventory: {Count} gumballs.");
        sb.AppendLine(_state == _soldOutState ? "Machine is sold out." : "Machine is waiting for quarter.");
        return sb.ToString();
    }
}