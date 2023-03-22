using PizzaMizza.Core.Models;
using PizzaMizza.Core.Models.Base;
using PizzaMizza.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Implementations
{
    internal class PizzaService:IPizza<Pizza>
    {
        List<Pizza> pizzalist = new List<Pizza>();
        List<PizzaIng> pizzaIngs = new List<PizzaIng>();
        public void Create(Pizza pizza)
        {
            Console.WriteLine("Please enter a pizza name");
            pizza.Name = Console.ReadLine();
          
            bool status = false;

            while (!status)
            {
                Console.WriteLine($"1: {PizzaSize.Small}");
                Console.WriteLine($"2: {PizzaSize.Medium}");
                Console.WriteLine($"3: {PizzaSize.Large}");
                int  request = int.Parse(Console.ReadLine());

                switch (request)
                {
                    case 1:
                        pizza.size = PizzaSize.Small;
                        status = true;
                        break;
                    case 2:
                        pizza.size = PizzaSize.Medium;
                        status= true;
                        break;

                    case 3:
                        pizza.size = PizzaSize.Large;
                        status = true;
                        break;
                        default: 
                        Console.WriteLine("Please select step number correctly");
                        break;
                }
                
               
            }
            Console.WriteLine("Press e for extras");
            Console.WriteLine("Press c for countinue");
            string extras = Console.ReadLine();
            if(extras != "c" )
            {
                switch (extras)
                {
                    case "e":
                      
                        Console.WriteLine("Please select extra ingredients");
                        Console.WriteLine("Press q to quit");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine($"1: {PizzaIngridents.Cheese}");
                        Console.WriteLine($"2: {PizzaIngridents.Mayo}");
                        Console.WriteLine($"3: {PizzaIngridents.Chicken}");
                        Console.WriteLine($"4: {PizzaIngridents.Meat}");
                        Console.WriteLine($"5: {PizzaIngridents.Mushroom}");
                        Console.WriteLine($"6: {PizzaIngridents.OliveOil}");
                        Console.WriteLine($"7: {PizzaIngridents.Onion}");
                        Console.WriteLine($"8: {PizzaIngridents.Garlic}");
                        Console.WriteLine($"9: {PizzaIngridents.Parsley}");
                        Console.WriteLine($"10: {PizzaIngridents.Mozarella}");
                        
                        string extrarequest = Console.ReadLine();
                        while( extrarequest != "q" )
                        {
                            switch (extrarequest)
                            {
                                case "1":
                                    pizzaIngs.Add((PizzaIng)PizzaIngridents.Cheese);
                                    break;
                                case "2":
                                    pizzaIngs.Add((PizzaIng)PizzaIngridents.Mayo);
                                    break;
                                case "3":
                                    pizzaIngs.Add((PizzaIng)PizzaIngridents.Chicken);
                                    break;
                                case "4":
                                    pizzaIngs.Add((PizzaIng)PizzaIngridents.Meat);
                                    break;
                                case "5":
                                    pizzaIngs.Add((PizzaIng)PizzaIngridents.Mushroom);
                                    break;
                                case "6":
                                    pizzaIngs.Add((PizzaIng)PizzaIngridents.OliveOil);
                                    break;
                                case "7":
                                    pizzaIngs.Add((PizzaIng)PizzaIngridents.Onion);
                                    break;
                                case "8":
                                    pizzaIngs.Add((PizzaIng)PizzaIngridents.Garlic);
                                    break;
                                case "9":
                                    pizzaIngs.Add((PizzaIng)PizzaIngridents.Parsley);
                                    break;
                                case "10":
                                    pizzaIngs.Add((PizzaIng)PizzaIngridents.Mozarella);
                                    break;
                                default:
                                    Console.WriteLine("You can select only 1-10");
                                    break;
                            }
                            Console.WriteLine("Press q to quit");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine($"1: {PizzaIngridents.Cheese}");
                            Console.WriteLine($"2: {PizzaIngridents.Mayo}");
                            Console.WriteLine($"3: {PizzaIngridents.Chicken}");
                            Console.WriteLine($"4: {PizzaIngridents.Meat}");
                            Console.WriteLine($"5: {PizzaIngridents.Mushroom}");
                            Console.WriteLine($"6: {PizzaIngridents.OliveOil}");
                            Console.WriteLine($"7: {PizzaIngridents.Onion}");
                            Console.WriteLine($"8: {PizzaIngridents.Garlic}");
                            Console.WriteLine($"9: {PizzaIngridents.Parsley}");
                            Console.WriteLine($"10: {PizzaIngridents.Mozarella}");
                            extrarequest = Console.ReadLine();
                        }
                        break;
                }
            }


            Console.WriteLine("Please select the pizza price");
            pizza.price = double.Parse(Console.ReadLine());
            pizzalist.Add(pizza);

        }

        public void Show()
        {   
            if(pizzalist.Count > 0)
            {
                foreach (var item in pizzalist)
                {
                    Console.WriteLine(item);
                }
                ShowById();
            }
            else
            {
                Console.WriteLine("There is no pizza yet. Please add a pizza");
            }
           
        }

       public void ShowById()
        {
            Console.WriteLine("Enter id number for extra information about pizza");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < pizzalist.Count; i++)
            {
                if (pizzalist[i].Id == id)
                {
                    for (int j = 0; j < pizzaIngs.Count; j++)
                    {
                        Console.WriteLine($"Extra ingredients: {(PizzaIngridents)pizzaIngs[j]}");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid id number. Try again!!!");
                }
            }

        }

    }
}
