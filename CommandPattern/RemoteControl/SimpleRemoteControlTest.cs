using CommandPattern.RemoteControl.Commands.GarageDoorCommands;
using CommandPattern.RemoteControl.Commands.LightCommands;

namespace CommandPattern.RemoteControl
{
    public static class SimpleRemoteControlTest
    {
        public static void Test()
        {
            var remote = new SimpleRemoteControl();
            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var garageDoor = new GarageDoor();
            var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommand(garageDoorOpenCommand);
            remote.ButtonWasPressed();
        }
    }
}
