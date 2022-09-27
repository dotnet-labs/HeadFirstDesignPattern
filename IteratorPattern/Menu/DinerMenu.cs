﻿using IteratorPattern.Iterator;

namespace IteratorPattern.Menu;

public class DinerMenu : IMenu
{
    public static readonly int MaxItems = 6;
    private int _numberOfItems;
    private readonly MenuItem[] _menuItems = new MenuItem[MaxItems];

    public DinerMenu()
    {
        _numberOfItems = 0;
        AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99m);
        AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99m);
        AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29m);
        AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05m);
    }

    public void AddItem(string name, string description, bool vegetarian, decimal price)
    {
        if (_numberOfItems >= MaxItems)
        {
            Console.WriteLine("Sorry, menu is full! Can't add new item to menu.");
        }
        _menuItems[_numberOfItems] = new MenuItem(name, description, vegetarian, price);
        _numberOfItems++;
    }

    public IIterator CreateIterator()
    {
        return new DinnerMenuIterator(_menuItems);
    }
}