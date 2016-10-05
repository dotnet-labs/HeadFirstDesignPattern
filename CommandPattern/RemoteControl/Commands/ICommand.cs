namespace CommandPattern.RemoteControl.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
