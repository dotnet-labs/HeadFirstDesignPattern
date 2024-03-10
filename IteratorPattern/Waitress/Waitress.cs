using IteratorPattern.Iterator;
using IteratorPattern.Menu;

namespace IteratorPattern.Waitress;

public class Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
{
    public void PrintMenu()
    {
        var pancakeIterator = pancakeHouseMenu.CreateIterator();
        var dinerIterator = dinerMenu.CreateIterator();
        Console.WriteLine("MENU\n------\nBREAKFAST");
        PrintMenu(pancakeIterator);
        Console.WriteLine("\nLUNCH");
        PrintMenu(dinerIterator);
    }

    private static void PrintMenu(IIterator iterator)
    {
        while (iterator.HasNext())
        {
            var menuItem = (MenuItem?)iterator.Next();
            if (menuItem == null)
            {
                break;
            }
            Console.WriteLine(menuItem.Name + ", " + menuItem.Price + ", " + menuItem.Description);
        }
    }
}