using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using problem1.BL;
using problem1.UI;

namespace problem1.DL
{
    class MenuItemDL
    {
        public static void storeInFile()
        {
            string path = "D:\\BSCS\\Second Semester\\C#\\Week 05 PD\\Coffee Shop\\problem1\\Menu.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < CoffeeShopDL.shop.foodMenu.Count; i++)
            {
                file.WriteLine(CoffeeShopDL.shop.foodMenu[i].name + "," + CoffeeShopDL.shop.foodMenu[i].type + "," + CoffeeShopDL.shop.foodMenu[i].price);
            }
            file.Flush();
            file.Close();
        }
        public static void loadFromFile()
        {
            string path = "D:\\BSCS\\Second Semester\\C#\\Week 05 PD\\Coffee Shop\\problem1\\Menu.txt";
            string line;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    load_list(line);
                }
                file.Close();
            }
        }
       /* public static void load_list(string line)
        {
            MenuItem m = new MenuItem(parseData(1, line), parseData(2, line), int.Parse(parseData(3, line)));
            CoffeeShopDL.shop.addMenuItem(m);
        }*/

        public static void load_list(string line)
        {
            string[] splittedRecord = line.Split(',');
            /*string name = splittedRecord[0];
            string type = splittedRecord[1];
            int price = int.Parse(splittedRecord[2]);
            MenuItem m = new MenuItem(name,type ,price );*/
            MenuItem m = new MenuItem(splittedRecord[0], splittedRecord[1], int.Parse(splittedRecord[2]));
            CoffeeShopDL.shop.addMenuItem(m);
        }


        public static string parseData(int record, string line)
        {
            string item = "";
            int comma = 1;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    comma = comma + 1;
                }
                else if (comma == record)
                {
                    item = item + line[i];
                }
            }
            return item;
        }
    }
}
