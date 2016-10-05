using CommandPattern.RemoteControl.Commands;
using System;
using System.Text;

namespace CommandPattern.RemoteControl
{
    public class RemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;
        private ICommand _undoCommand;

        public RemoteControl()
        {
            AssignEmptyCommandToSlots();
        }

        private void AssignEmptyCommandToSlots()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();

            for (var i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
            _undoCommand = noCommand;
        }

        private static void EnsureSlotNumberIsValid(int slot)
        {
            if (slot < 0 || slot > 6)
            {
                throw new ArgumentException("Slot number is out of range.");
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            EnsureSlotNumberIsValid(slot);
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("\n------ Remote Control ------\n");
            for (var i = 0; i < _onCommands.Length; i++)
            {
                sb.AppendLine($"[slot {i}]\t {_onCommands[i].GetType().Name}\t{_offCommands[i].GetType().Name}");
            }
            return sb.ToString();
        }
    }
}
