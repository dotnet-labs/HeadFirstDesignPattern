namespace CommandPattern.RemoteControl.Commands.CeilingFanCommands;

public class CeilingFanOnCommand : ICommand
{
    private readonly CeilingFan _ceilingFan;

    public CeilingFanOnCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        _ceilingFan.On();
    }

    public void Undo()
    {
        _ceilingFan.Off();
    }
}