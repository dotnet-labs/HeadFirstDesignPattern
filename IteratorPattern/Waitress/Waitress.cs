using IteratorPattern.Iterator;
using IteratorPattern.Menu;
using System;

namespace IteratorPattern.Waitress
{
    public class Waitress
    {
        private readonly PancakeHouseMenu _pancakeHouseMenu;
        private readonly DinerMenu _dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            var pancakeIterator = _pancakeHouseMenu.CreateIterator();
            var dinerIterator = _dinerMenu.CreateIterator();
            Console.WriteLine("MENU\n------\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private static void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                var menuItem = (MenuItem)iterator.Next();
                Console.WriteLine(menuItem.Name + ", " + menuItem.Price + ", " + menuItem.Description);
            }
        }
    }
}
