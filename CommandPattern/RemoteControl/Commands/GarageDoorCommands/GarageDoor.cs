namespace CommandPattern.RemoteControl.Commands.GarageDoorCommands;

public class GarageDoor
{
    public void Open()
    {
        Console.WriteLine("Garage Door is opened.");
    }

    public void Close()
    {
        Console.WriteLine("Garage Door is closed.");
    }
}
