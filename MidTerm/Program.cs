using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;          

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory.DairyRead();
            Inventory.BeveragesRead();
            Inventory.ProduceRead();
            Inventory.MeatsRead();
            Inventory.SnacksRead();
            //Console.WriteLine(Inventory.Products.Count); 
            //Inventory.AddItem();
            //WorkHorse.MainWork();
            Console.WriteLine(Inventory.DairyCount());
            //foreach (string item in Product.Dairy)
            //{
            //    Console.WriteLine(item);
            //}
            //Inventory.Dairy();
            //foreach (string[] item in Product.ShoppingCart)
            //{
            //    foreach (string z in item)
            //    {
            //        Console.WriteLine(z);
            //    }
            //}
        }
    }
}
