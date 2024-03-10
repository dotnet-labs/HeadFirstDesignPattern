namespace CommandPattern.RemoteControl.Commands.LightCommands;

public class Light(string name = "")
{
    public void On()
    {
        Console.WriteLine($"{name} Light is On.");
    }

    public void Off()
    {
        Console.WriteLine($"{name} Light is Off.");
    }
}