using System;

namespace CommandPattern.RemoteControl.Commands.Stereo
{
    public class Stereo
    {
        private readonly string _name;

        public Stereo(string name = "")
        {
            _name = name;
        }

        public void On()
        {
            Console.WriteLine($"{_name} Stereo is On.");
        }

        public void Off()
        {
            Console.WriteLine($"{_name} Stereo is Off.");
        }

        public void SetCd()
        {
            Console.WriteLine($"{_name} Stereo mode is CD.");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"{_name} Stereo volume is {level}.");
        }
    }
}
