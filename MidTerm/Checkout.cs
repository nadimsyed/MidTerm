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
        public static string SubTotalCart()
        {
            string SubTotal = "";
            foreach (string item in Product.ShoppingCart)
	        {
		        ArrayList ModifyShoppingCartPrices = new ArrayList();
                Console.WriteLine(item);
                
                string[] items = item.Split(' ');
                double JustPrice = double.Parse(item[2].ToString());
                double JustQuantity = double.Parse(item[1].ToString());
                //double ChangingQuantitytoDouble = (double)ModifyShoppingCartPrices[1];
                //double ChangingPricetoDouble = (double)ModifyShoppingCartPrices[2];
                double SubtotalofCart = JustPrice * JustQuantity;
                SubTotal = SubtotalofCart.ToString();  
            }
            return SubTotal;
        }

        public static string TaxingSales()
        {
            string SalesTax = "";
            foreach (string item in Product.ShoppingCart)
            {
                ArrayList ModifyShoppingCartPrices = new ArrayList();
                Console.WriteLine(item);

                string[] items = item.Split(' ');
                double JustPrice = double.Parse(item[2].ToString());
                double JustQuantity = double.Parse(item[1].ToString());
                //double ChangingQuantitytoDouble = (double)ModifyShoppingCartPrices[1];
                //double ChangingPricetoDouble = (double)ModifyShoppingCartPrices[2];
                double total = double.Parse(SubTotalCart());
                double salesTax = total * .06;

                SalesTax = salesTax.ToString();
            }
            return SalesTax;
        }
        public static string GrandTotalofCart()
        {
            string GrandTotal = "";
            foreach (string item in Product.ShoppingCart)
            {
                ArrayList ModifyShoppingCartPrices = new ArrayList();
                Console.WriteLine(item);

                string[] items = item.Split(' ');
                double JustPrice = double.Parse(item[2].ToString());
                double JustQuantity = double.Parse(item[1].ToString());
                //double ChangingQuantitytoDouble = (double)ModifyShoppingCartPrices[1];
                //double ChangingPricetoDouble = (double)ModifyShoppingCartPrices[2];
                double total = double.Parse(SubTotalCart());
                double salesTax = total * .06;
                double total2 = total + salesTax;

                GrandTotal = total2.ToString();
            }
            return GrandTotal;
        }

		public static void CheckoutM()
		{
            Console.Write($"Your total is : ");

            

            foreach (string item in Product.ShoppingCart)
            {           
                ArrayList ModifyShoppingCartPrices= new ArrayList();              
                Console.WriteLine(item);
                
                string[] items = item.Split(' ');
                double JustPrice = double.Parse(item[2].ToString());
                double JustQuantity = double.Parse(item[1].ToString());
                //double ChangingQuantitytoDouble = (double)ModifyShoppingCartPrices[1];
                //double ChangingPricetoDouble = (double)ModifyShoppingCartPrices[2];
                double SubtotalofCart= JustPrice*JustQuantity;
                double SalesTax = SubtotalofCart * .06;

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
