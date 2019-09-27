using CompositePattern.MenuComponent;
using System;

namespace CompositePattern
{
    internal class Program
    {
        private static void Main()
        {
            MenuTestDrive();
            Console.ReadKey();
        }

        static void MenuTestDrive()
        {
            IMenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            IMenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            IMenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            IMenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

            IMenuComponent allMenus = new Menu("ALL MENUS", "All menus combined.");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new MenuItem("Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true, 3.89m));
            dinerMenu.Add(dessertMenu);
            dessertMenu.Add(new MenuItem("Apple Pie",
                "Apple pie with a flaky crust, topped with vanilla ice cream",
                true, 1.59m));

            var waitress = new Waitress.Waitress(allMenus);
            waitress.PrintMenu();
        }
    }
}
