namespace CommandPattern.RemoteControl.Commands.LightCommands;

public class LightOnCommand(Light light) : ICommand
{
    public void Execute()
    {
        light.On();
    }

    public void Undo()
    {
        light.Off();
    }
}