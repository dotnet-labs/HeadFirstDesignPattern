namespace CommandPattern.RemoteControl.Commands.CeilingFanCommands;

public class CeilingFanOnCommand(CeilingFan ceilingFan) : ICommand
{
    public void Execute()
    {
        ceilingFan.On();
    }

    public void Undo()
    {
        ceilingFan.Off();
    }
}