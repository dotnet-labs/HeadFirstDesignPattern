namespace CommandPattern.RemoteControl.Commands.LightCommands;

public class Light
{
    private readonly string _name;

    public Light(string name = "")
    {
        _name = name;
    }

    public void On()
    {
        Console.WriteLine($"{_name} Light is On.");
    }

    public void Off()
    {
        Console.WriteLine($"{_name} Light is Off.");
    }
}