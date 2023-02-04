using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using problem1.BL;
using problem1.DL;

namespace problem1.UI
{
    class CoffeeShopUI
    {
        public static string takeInputShopName()
        {
            string shopName;
            Console.WriteLine();
            Console.Write(" Enter Shop Name: ");
            shopName = Console.ReadLine();
            return shopName;
        }
        public static MenuItem takeInputNewItem()
        {
            string type, name;
            int price;
            Console.Write(" Enter Name of Item: ");
            name = Console.ReadLine();
            Console.Write(" Enter Type of Item (Food/Drink): ");
            type = Console.ReadLine();
            Console.Write(" Enter Price of Item: ");
            price = int.Parse(Console.ReadLine());
            MenuItem item = new MenuItem(name,type,price);
            return item;
        }
        public static void showConfirmationMessage()
        {
            Console.WriteLine();
            Console.WriteLine("  New Item added successfully.");
        }
        public static void showCheapestItem(MenuItem item)
        {
            Console.WriteLine();
            Console.WriteLine("Item Name: " + item.name);
            Console.WriteLine("Item Type: " + item.type);
            Console.WriteLine("Item Price: " + item.price);
        }
        public static void showDrinkMenu(List<string> drink)
        {
            Console.WriteLine();
            Console.WriteLine(" Drinks");
            Console.WriteLine("-------");
            foreach (string drinkName in drink)
            {
                Console.WriteLine("\t" + drinkName);
            }
        }
        public static void showFoodMenu(List<string> food)
        {
            Console.WriteLine();
            Console.WriteLine(" Foods");
            Console.WriteLine("------");
            foreach (string foodName in food)
            {
                Console.WriteLine("\t" + foodName);
            }
        }
        public static string takeInputOrder()
        {
            string order;
            Console.Write(" Enter your order: ");
            order = Console.ReadLine();
            return order;
        }
        public static void showOrderMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
        }
        public static void showFulfillOrder(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
        }
        public static void showOrderList(List<string> orderList)
        {
            Console.WriteLine();
            Console.WriteLine(" Order");
            Console.WriteLine("------");
            foreach (string order in orderList)
            {
                Console.WriteLine("\t" + order);
            }
        }
        public static void showTotalAmount(int amount)
        {
            Console.WriteLine();
            Console.WriteLine("  Total Payable Amount: " + amount);
        }
    }
}
