using CommandPattern.RemoteControl;
using System;

namespace CommandPattern
{
    internal class Program
    {
        private static void Main()
        {
            SimpleRemoteControlTest.Test();

            RemoteLoader.Test();
            Console.ReadKey();
        }
    }
}
