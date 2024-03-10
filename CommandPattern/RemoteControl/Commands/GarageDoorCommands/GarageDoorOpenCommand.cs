namespace CommandPattern.RemoteControl.Commands.GarageDoorCommands;

public class GarageDoorOpenCommand(GarageDoor garageDoor) : ICommand
{
    public void Execute()
    {
        garageDoor.Open();
    }

    public void Undo()
    {
        garageDoor.Close();
    }
}