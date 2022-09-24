using IteratorPattern.Iterator;
using IteratorPattern.Menu;

namespace IteratorPattern.Waitress;

public class Waitress
{
    private readonly IMenu _pancakeHouseMenu;
    private readonly IMenu _dinerMenu;

    public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
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
            var menuItem = (MenuItem?)iterator.Next();
            if (menuItem == null)
            {
                break;
            }
            Console.WriteLine(menuItem.Name + ", " + menuItem.Price + ", " + menuItem.Description);
        }
    }
}