namespace CommandPattern.RemoteControl.Commands.Stereo;

public class StereoOnWithCdCommand(Stereo stereo) : ICommand
{
    public void Execute()
    {
        stereo.On();
        stereo.SetCd();
        stereo.SetVolume(11);
    }

    public void Undo()
    {
        stereo.Off();
    }
}