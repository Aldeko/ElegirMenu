using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuskalDonals
{
    class Program
    {
        static void Main(string[] args)
        {
            int customerChoice, menuChoice, burgerChoice, drinkChoice;
            string[] menus = { "Eusko label", "Pirenaika", "Ardi latxa" };
            string[] burger = { "Anboto Burger", "Oiz Burger", "Gorbea Burger" };
            string chips;
            string[] drinks = {"Coca cola","Fanta","Agua" };
            const int MENU = 1, BURGER = 2, DRINKS = 3, EXIT = 4;
            do
            {
                Console.WriteLine("1 - Pedir Menu");
                Console.WriteLine("2 - Pedir Hamburguesa");
                Console.WriteLine("3 - Pedir bebida");
                Console.WriteLine("4 - Salir");
                customerChoice = Int32.Parse(Console.ReadLine());
              
                    switch (customerChoice)
                    {
                        case MENU:
                        Console.WriteLine("Elegir Menu");
                        for (int i = 0; i < menus.Length; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + menus[i]);
                        }
                        menuChoice = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Aqui tienes tu menu " + menuChoice);
                        break;

                        case BURGER:
                            Console.WriteLine("Elegir hamburguesa");
                        for (int i = 0; i < drinks.Length; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + burger[i]);
                        }
                        burgerChoice = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Aqui tiene su hamburguesa " + burger[burgerChoice-1]);
                        do
                        {
                            Console.WriteLine("Quieres patatatas con tu hamburguesa (S/N)");
                            chips = Console.ReadLine();                         
                        }
                        while (chips.ToUpper() != "S" && chips.ToUpper()!="N");

                        if (chips.ToUpper() == "S")
                        {
                            Console.WriteLine("Aqui tienes tu hamburguesa con Patatas ");
                        }
                        else if (chips.ToUpper() == "N")
                        {
                            Console.WriteLine("Aqui tienes tu hamburguesa sin Patatas ");
                        }
                        break;

                        case DRINKS:
                        Console.WriteLine("Elegir bebida");
                        for (int i = 0; i < drinks.Length; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + drinks[i]);
                        }
                        drinkChoice = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Aqui tienes tu bebida " + drinkChoice);
                        break;
                    }



                
            }
            while (customerChoice != EXIT);

           
            

        }
    }
}
