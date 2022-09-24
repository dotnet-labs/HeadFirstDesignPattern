namespace CommandPattern.RemoteControl.Commands.CeilingFanCommands;

public class CeilingFan
{
    private readonly string _name;

    public CeilingFan(string name = "")
    {
        _name = name;
    }

    public void On()
    {
        Console.WriteLine($"{_name} Fan is On.");
    }

    public void Off()
    {
        Console.WriteLine($"{_name} Fan is Off");
    }
}