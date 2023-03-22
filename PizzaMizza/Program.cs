using PizzaMizza.Core.Models.Base;
using PizzaMizza.Implementations;

PizzaService PizzaService = new PizzaService();

Console.WriteLine("Welcome to PizzaMizza");
Console.WriteLine("Press 1: to show all pizzas");
Console.WriteLine("Press 2: to create a pizza by yourself");
Console.WriteLine("Press q: to quit from application");

string input = Console.ReadLine();

while (input != "q")
{
	switch (input)
	{
		case "1":
			PizzaService.Show();
			break;
		case "2":
			Pizza pizza = new Pizza();
			PizzaService.Create(pizza);
			break;
		default:
			Console.WriteLine("Please select input number correctly");
			break;
	}
	Console.WriteLine("--------------------------");
    Console.WriteLine("Press 1: to show all pizzas");
    Console.WriteLine("Press 2: to create a pizza by yourself");
    Console.WriteLine("Press q: to quit from application");
    input = Console.ReadLine();
}