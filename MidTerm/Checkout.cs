using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    class Checkout
    {
		public static void CheckoutM()
		{
            Console.Write($"Your total is : ");

            foreach (string item in Product.ShoppingCart)
            {           
               ArrayList ModifyShoppingCartPrices= new ArrayList();              
                Console.WriteLine(item);
                ModifyShoppingCartPrices.Add(item);
                string[] items = item.Split(' ');
                double ChangingStringtoInt= (double)ModifyShoppingCartPrices[1]
                //Inventory.GrabBeveragesPrice();
                //Inventory.GrabDairyPrice();
                //Inventory.GrabMeatsPrice();
                //Inventory.GrabProducePrice();
                //Inventory.GrabSnacksPrice();
                

            }

            Console.WriteLine("--- Receipt ---");
            foreach (string item in Product.ShoppingCart)
            {
                //Console.WriteLine
                //(
                //    "",
                //    itemValue,
                //    itemKey,
                //    [itemKey],
                //    itemValue * [itemKey]
                //);
            }
            //double subTotal = calculateSubTotal(Product.ShoppingCart);
            //double salesTax = calculateSalesTax(Product.ShoppingCart);
            //double total = calculateTotal(Product.ShoppingCart);

            Console.WriteLine("Thank you for shopping with us!");

        }
        public static void ReturntoShop()
        {

        }
    }
}
