using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1.BL
{
    class CoffeeShop
    {
        public string shopName;
        public List<MenuItem> foodMenu = new List<MenuItem>();
        public List<string> order = new List<string>();

        public CoffeeShop(string shopName)
        {
            this.shopName = shopName;
        }
        public void addMenuItem(MenuItem item)
        {
            foodMenu.Add(item);
        }
        public void addOrder(string oder)
        {
            order.Add(oder);
        }
        public string FulfillOrder()
        {
            string message;
            if (order == null)
            {
                message = "  All Orders have been fulfilled.";
            }
            else
            {
                message = "  The " + order[0] + " is ready.";
                order.RemoveAt(0);
            }
            return message;
        }
        public List<string> listOrders()
        {
            return order;
        }
        public int dueAmount()
        {
            int total_amount = 0;
            foreach (string a in order)
            {
                foreach (MenuItem b in foodMenu)
                {
                    if (a == b.name)
                    {
                        total_amount = total_amount + b.price;
                        break;
                    }
                }
            }
            return total_amount;
        }
        public MenuItem cheapestItem()
        {
            MenuItem item;                // sorted in ascending order 
            List<MenuItem> sortedList = foodMenu.OrderBy(o => o.price).ToList();
            item = sortedList[0];
            return item;
        }
        public List<string> drinks()
        {
            List<string> drink = new List<string>();
            foreach (MenuItem a in foodMenu)
            {
                string name = "";
                if (a.type == "Drink")
                {
                    name = a.name;
                    drink.Add(name);
                }
            }
            return drink;
        }
        public List<string> foods()
        {
            List<string> food = new List<string>();
            foreach (MenuItem a in foodMenu)
            {
                string name = "";
                if (a.type == "Food" || a.type == "food")
                {
                    name = a.name;
                    food.Add(name);
                }
            }
            return food;
        }
    }
}
