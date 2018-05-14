using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace MidTerm
{
    class Product
    {
        private static ArrayList shoppingCart = new ArrayList();

        private static ArrayList dairy = new ArrayList();
        private static ArrayList meats = new ArrayList();
        private static ArrayList beverages = new ArrayList();
        private static ArrayList produce = new ArrayList();
        private static ArrayList snacks = new ArrayList();


        public static ArrayList ShoppingCart { get => shoppingCart; set => shoppingCart = value; }
        public static ArrayList Dairy { get => dairy; set => dairy = value; }
        public static ArrayList Meats { get => meats; set => meats = value; }
        public static ArrayList Beverages { get => beverages; set => beverages = value; }
        public static ArrayList Produce { get => produce; set => produce = value; }
        public static ArrayList Snacks { get => snacks; set => snacks = value; }

        public static ArrayList RunningCart(string itemName, string itemQuantity, string itemPrice)
        {
            string itemAndQuantity = itemName + " " + itemQuantity + " " + itemPrice;
            ShoppingCart.Add(itemAndQuantity);
            return ShoppingCart;
        }
    }
}
