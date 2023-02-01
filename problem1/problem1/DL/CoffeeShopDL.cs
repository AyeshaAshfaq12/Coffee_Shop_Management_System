using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using problem1.BL;
using problem1.UI;
using System.IO;

namespace problem1.DL
{
    class CoffeeShopDL
    {
        
        public static string name;
        public static string shopName(string shop)
        {
            name = shop;
            return name;
        }

        public static CoffeeShop shop = new CoffeeShop(name);
        /*public static void addMenu()            // Adding items given in MANUAL
        {
            MenuItem item = new MenuItem("orange juice", "Drink", 60);
            shop.addMenuItem(item);
            item = new MenuItem("lemonade", "Drink", 50);
            shop.addMenuItem(item);
            item = new MenuItem("cranberry juice", "Drink", 100);
            shop.addMenuItem(item);
            item = new MenuItem("pineapple juice", "Drink", 100);
            shop.addMenuItem(item);
            item = new MenuItem("lemon iced tea", "Drink", 120);
            shop.addMenuItem(item);
            item = new MenuItem("vanilla chai latte", "Drink", 150);
            shop.addMenuItem(item);
            item = new MenuItem("hot chocolate","Drink", 140);
            shop.addMenuItem(item);
            item = new MenuItem("iced coffee", "Drink", 140);
            shop.addMenuItem(item);
            item = new MenuItem("tuna sandwich", "Food", 300);
            shop.addMenuItem(item);
            item = new MenuItem("ham and cheese sandwich", "Food", 300);
            shop.addMenuItem(item);
            item = new MenuItem("egg sandwich", "Food", 200);
            shop.addMenuItem(item);
            item = new MenuItem("steak", "Food", 900);
            shop.addMenuItem(item);
            item = new MenuItem("hamburger", "Food", 600);
            shop.addMenuItem(item);
            item = new MenuItem("cinnamon roll", "Food", 150);
            shop.addMenuItem(item);
        }*/
        public static void addNewItemInMenu(MenuItem item)
        {
            shop.addMenuItem(item);
            MenuItemDL.storeInFile();
        }
        public static MenuItem getCheapestItemFromMenu()
        {
            return shop.cheapestItem();
        }
        public static List<string> getDrinkMenu()
        {
            return shop.drinks();
        }
        public static List<string> getFoodMenu()
        {
            return shop.foods();
        }
        public static string addOrderInOrderListIfItemExistsInMenu(string order)
        {
            string message = "";
            bool flag = false;
            foreach(MenuItem item in shop.foodMenu)
            {
                if(order == item.name)
                {
                    shop.addOrder(order);
                    message = "  Order added Successfully.";
                    flag = true;
                    break;
                }
            }
            if(flag == false)
            {
                message = "  Sorry ! This item is currently unavailable.";
            }
            return message;
        }
        public static string getFulfillOrder()
        {
            return shop.FulfillOrder();
        }
        public static List<string> getOrderList()
        {
            return shop.listOrders();
        }
        public static int getTotalAmount()
        {
            return shop.dueAmount();
        }
        
    }
}
