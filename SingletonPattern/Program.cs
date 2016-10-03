using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CsharpInDepthSingleton();
            Console.ReadKey();
        }

        private static void CsharpInDepthSingleton()
        {
            var boiler1 = ChocolateBoiler.Instance;
            var boiler2 = ChocolateBoiler.Instance;
            var boiler3 = ChocolateBoiler.Instance;
            Console.Write("boiler1\n\t");
            boiler1.Fill();
            Console.Write("boiler3\n\t");
            boiler3.Fill();
            Console.Write("boiler1\n\t");
            boiler1.Boil();
            Console.Write("boiler2\n\t");
            boiler2.Fill();
            Console.Write("boiler2\n\t");
            boiler2.Drain();
            Console.Write("boiler2\n\t");
            boiler2.Fill();
            Console.Write("boiler1\n\t");
            boiler1.Drain();
            Console.Write("boiler1\n\t");
            boiler1.Boil();
            Console.Write("boiler2\n\t");
            boiler2.Drain();
        }
    }
}
