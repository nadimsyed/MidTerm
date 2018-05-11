using System;
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
                Console.WriteLine(item);
            }

            Console.WriteLine("--- Receipt ---");
            foreach (string item in Product.ShoppingCart)
            {
                Console.WriteLine
                (
                    "",
                    item.Value,
                    item.Key,
                    [item.Key],
                    item.Value * [item.Key]
                );
            }
            var subTotal = calculateSubTotal(order);
            var salesTax = calculateSalesTax(order);
            var total = calculateTotal(order);

        }
    }
}
