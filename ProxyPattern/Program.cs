using ProxyPattern.Castle;
using ProxyPattern.MatchMaking;
using System;

namespace ProxyPattern
{
    internal class Program
    {
        private static void Main()
        {
            CastleDynamicProxyTest.Test();
            Console.ReadKey();

            MatchMakingTestDrive.Run();
            Console.ReadKey();
        }
    }
}
