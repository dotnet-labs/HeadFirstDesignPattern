namespace CommandPattern.RemoteControl.Commands.CeilingFanCommands;

public class CeilingFanOffCommand(CeilingFan ceilingFan) : ICommand
{
    public void Execute()
    {
        ceilingFan.Off();
    }

    public void Undo()
    {
        ceilingFan.On();
    }
}