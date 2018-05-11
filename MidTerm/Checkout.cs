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
            Console.Write($"Your total is : {total}");

            foreach (string item in Product.ShoppingCart)
            {           
               ArrayList ModifyShoppingCartPrices= new ArrayList();              
                Console.WriteLine(item);
                ModifyShoppingCartPrices.Add(item);
                item.Split(' ');
                double ChangingStringtoInt= (double)ModifyShoppingCartPrices[1];
                

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
            var subTotal = calculateSubTotal(Product.ShoppingCart);
            var salesTax = calculateSalesTax(Product.ShoppingCart);
            var total = calculateTotal(Product.ShoppingCart);

            Console.WriteLine("Thank you for shopping with us!");

        }
        public static void ReturntoShop()
        {

        }
    }
}
