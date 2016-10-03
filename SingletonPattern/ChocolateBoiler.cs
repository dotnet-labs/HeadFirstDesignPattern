using System;

namespace SingletonPattern
{
    public class ChocolateBoiler
    {
        private static readonly Lazy<ChocolateBoiler> Lazy =
            new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());

        public static ChocolateBoiler Instance => Lazy.Value;

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        private bool Empty { get; set; }
        private bool Boiled { get; set; }

        public void Fill()
        {
            if (!Empty)
            {
                Console.WriteLine();
                return;
            }
            Empty = false;
            Boiled = false;
            Console.WriteLine("Fill the boilder with a milk/chocolate mixture.");
        }

        public void Drain()
        {
            if (Empty || !Boiled)
            {
                Console.WriteLine();
                return;
            }
            Console.WriteLine("Drain the boiled milk and chocolate.");
            Empty = true;
        }

        public void Boil()
        {
            if (Empty || Boiled)
            {
                Console.WriteLine();
                return;
            }
            Console.WriteLine("Bring the contents to a boil.");
            Boiled = true;
        }
    }
}
