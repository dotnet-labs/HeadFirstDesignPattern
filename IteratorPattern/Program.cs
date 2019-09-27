using IteratorPattern.Menu;
using System;

namespace IteratorPattern
{
    internal class Program
    {
        private static void Main()
        {
            MenuTestDrive();
            Console.ReadKey();
        }

        private static void MenuTestDrive()
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            var waitress = new Waitress.Waitress(pancakeHouseMenu, dinerMenu);
            waitress.PrintMenu();
        }
    }
}
