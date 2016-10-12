using CompositePattern.MenuComponent;

namespace CompositePattern.Waitress
{
    public class Waitress
    {
        private readonly IMenuComponent _allMenus;

        public Waitress(IMenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }
    }
}
