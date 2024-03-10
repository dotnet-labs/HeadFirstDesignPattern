using CompositePattern.MenuComponent;

namespace CompositePattern.Waitress;

public class Waitress(IMenuComponent allMenus)
{
    public void PrintMenu()
    {
        allMenus.Print();
    }
}