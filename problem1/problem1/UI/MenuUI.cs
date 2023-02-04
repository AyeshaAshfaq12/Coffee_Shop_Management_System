using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1.UI
{
    class MenuUI
    {

        public static void clearScreen()
        {
            Console.WriteLine();
            Console.Write(" Press any key to continue_");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
        }
        public static int menu()
        {
            int option;
            Console.WriteLine();
            Console.WriteLine("\t\t\t   -------------------------------");
            Console.WriteLine("\t\t\t   |     Ayesha's Coffee Shop    |");
            Console.WriteLine("\t\t\t   -------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  -------------------------------");
            Console.WriteLine("  | Select one option from menu |");
            Console.WriteLine("  -------------------------------");
            Console.WriteLine();
            Console.WriteLine("\t 1. Add a menu item");
            Console.WriteLine("\t 2. View the Cheapest item in menu");
            Console.WriteLine("\t 3. View the Drinks menu");
            Console.WriteLine("\t 4. View the Food menu");
            Console.WriteLine("\t 5. Add order");
            Console.WriteLine("\t 6. Fulfill the order");
            Console.WriteLine("\t 7. View the order's List");
            Console.WriteLine("\t 8. Total Payable amount");
            Console.WriteLine("\t 9. Exit");
            Console.WriteLine();
            Console.Write(" Your Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        public static void displayOptionHeading(int option)
        {
            Console.WriteLine();
            if (option == 1)
            {
                Console.WriteLine(" Add a menu item");
                Console.WriteLine("----------------");
            }
            if (option == 2)
            {
                Console.WriteLine(" View the Cheapest item in menu");
                Console.WriteLine("-------------------------------");
            }
            if (option == 3)
            {
                Console.WriteLine(" View the Drinks menu");
                Console.WriteLine("---------------------");
            }
            if (option == 4)
            {
                Console.WriteLine(" View the Food menu");
                Console.WriteLine("-------------------");
            }
            if (option == 5)
            {
                Console.WriteLine(" Add order");
                Console.WriteLine("----------");
            }
            if (option == 6)
            {
                Console.WriteLine(" Fulfill the order");
                Console.WriteLine("------------------");
            }
            if (option == 7)
            {
                Console.WriteLine(" View the order's list");
                Console.WriteLine("----------------------");
            }
            if (option == 8)
            {
                Console.WriteLine(" Total Payable amount");
                Console.WriteLine("---------------------");
            }
            Console.WriteLine();
        }
    }
}
