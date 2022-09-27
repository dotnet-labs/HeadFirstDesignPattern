﻿using CommandPattern.RemoteControl.Commands;

namespace CommandPattern.RemoteControl
{
    public class SimpleRemoteControl
    {
        private ICommand _slot = null!;

        public void SetCommand(ICommand command)
        {
            _slot = command;
        }

        public void ButtonWasPressed()
        {
            _slot.Execute();
        }
    }
}
