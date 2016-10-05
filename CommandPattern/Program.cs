using CommandPattern.RemoteControl;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControlTest.Test();

            RemoteLoader.Test();
            Console.ReadKey();
        }
    }
}
