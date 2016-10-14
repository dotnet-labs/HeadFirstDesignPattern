using ProxyPattern.Castle;
using ProxyPattern.MatchMaking;
using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CastleDynamicProxyTest.Test();
            Console.ReadKey();

            MatchMakingTestDrive.Run();
            Console.ReadKey();
        }
    }
}
