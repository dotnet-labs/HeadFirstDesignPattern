namespace CommandPattern.RemoteControl.Commands.Stereo;

public class Stereo(string name = "")
{
    public void On()
    {
        Console.WriteLine($"{name} Stereo is On.");
    }

    public void Off()
    {
        Console.WriteLine($"{name} Stereo is Off.");
    }

    public void SetCd()
    {
        Console.WriteLine($"{name} Stereo mode is CD.");
    }

    public void SetVolume(int level)
    {
        Console.WriteLine($"{name} Stereo volume is {level}.");
    }
}