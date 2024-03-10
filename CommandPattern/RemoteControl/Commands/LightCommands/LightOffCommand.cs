namespace CommandPattern.RemoteControl.Commands.LightCommands;

public class LightOffCommand(Light light) : ICommand
{
    public void Execute()
    {
        light.Off();
    }

    public void Undo()
    {
        light.On();
    }
}