using FactoryPattern.PizzaProduct;
using FactoryPattern.PizzaStore;

var nyStore = new NyStylePizzaStore();
var pizza = nyStore.OrderPizza(PizzaType.Cheese);
Console.WriteLine($"You ordered a {pizza.Name}\n");

var chicagoStore = new ChicagoStylePizzaStore();
pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
Console.WriteLine($"You ordered a {pizza.Name}\n");

Console.ReadKey();