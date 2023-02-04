using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using problem1.BL;
using problem1.DL;
using problem1.UI;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItemDL.loadFromFile();
            //  CoffeeShopDL.addMenu();
            CoffeeShopDL.shopName(CoffeeShopUI.takeInputShopName());
            int option;
            option = MenuUI.menu();
            MenuUI.clearScreen();
            while(option < 9)
            {
                if(option == 1)
                {
                    MenuUI.displayOptionHeading(1);
                    CoffeeShopDL.addNewItemInMenu(CoffeeShopUI.takeInputNewItem());
                    CoffeeShopUI.showConfirmationMessage();
                }
                if (option == 2)
                {
                    MenuUI.displayOptionHeading(2);
                    CoffeeShopUI.showCheapestItem(CoffeeShopDL.getCheapestItemFromMenu());
                }
                if (option == 3)
                {
                    MenuUI.displayOptionHeading(3);
                    CoffeeShopUI.showDrinkMenu(CoffeeShopDL.getDrinkMenu());
                }
                if (option == 4)
                {
                    MenuUI.displayOptionHeading(4);
                    CoffeeShopUI.showFoodMenu(CoffeeShopDL.getFoodMenu());
                }
                if (option == 5)
                {
                    MenuUI.displayOptionHeading(5);
                    CoffeeShopUI.showOrderMessage(CoffeeShopDL.addOrderInOrderListIfItemExistsInMenu(CoffeeShopUI.takeInputOrder()));
                }
                if (option == 6)
                {
                    MenuUI.displayOptionHeading(6);
                    CoffeeShopUI.showFulfillOrder(CoffeeShopDL.getFulfillOrder());
                }
                if (option == 7)
                {
                    MenuUI.displayOptionHeading(7);
                    CoffeeShopUI.showOrderList(CoffeeShopDL.getOrderList());
                }
                if (option == 8)
                {
                    MenuUI.displayOptionHeading(8);
                    CoffeeShopUI.showTotalAmount(CoffeeShopDL.getTotalAmount());
                }
                MenuUI.clearScreen();
                option = MenuUI.menu();
                MenuUI.clearScreen();
            }
        }
    }
}
