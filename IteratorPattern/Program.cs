using IteratorPattern.Menu;
using IteratorPattern.Waitress;

var pancakeHouseMenu = new PancakeHouseMenu();
var dinerMenu = new DinerMenu();
var waitress = new Waitress(pancakeHouseMenu, dinerMenu);
waitress.PrintMenu();
Console.ReadKey();
