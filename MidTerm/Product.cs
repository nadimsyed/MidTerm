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

        public static ArrayList ShoppingCart { get => shoppingCart; set => shoppingCart = value; }

        public static ArrayList RunningCart(string itemName, int itemQuantity, string itemPrice)
        {
            string quantityString = itemQuantity.ToString();
            string itemAndQuantity = itemName + " " + quantityString + " " + itemPrice;
            ShoppingCart.Add(itemAndQuantity);
            return ShoppingCart;
        }
    }
}
