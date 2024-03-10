namespace CommandPattern.RemoteControl.Commands.CeilingFanCommands;

public class CeilingFan(string name = "")
{
    public void On()
    {
        Console.WriteLine($"{name} Fan is On.");
    }

    public void Off()
    {
        Console.WriteLine($"{name} Fan is Off");
    }
}