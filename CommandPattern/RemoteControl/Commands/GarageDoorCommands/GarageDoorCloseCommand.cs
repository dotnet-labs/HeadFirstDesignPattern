namespace CommandPattern.RemoteControl.Commands.GarageDoorCommands;

public class GarageDoorCloseCommand(GarageDoor garageDoor) : ICommand
{
    public void Execute()
    {
        garageDoor.Close();
    }

    public void Undo()
    {
        garageDoor.Open();
    }
}