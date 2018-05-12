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
        public static string LineTotal(ArrayList arrayList)
        {
            string SubTotal = "";
            foreach (string item in arrayList)
            {
                string[] items = item.Split(' ');
                //string item2 = Char.ToString(item[2]);
                //string item1 = Char.ToString(item[1]);
                double JustPrice = double.Parse(items[2]);
                double JustQuantity = double.Parse(items[1]);
                //double ChangingQuantitytoDouble = (double)ModifyShoppingCartPrices[1];
                //double ChangingPricetoDouble = (double)ModifyShoppingCartPrices[2];
                double SubtotalofCart = JustPrice * JustQuantity;
                //change to plus equal to have running total
                SubTotal = SubtotalofCart.ToString();
            }
            return SubTotal;
        }

        public static string SubTotalCart(ArrayList arrayList)
        {
            double SubTotal = 0;
            string SubTotalS = "";
            foreach (string item in arrayList)
	        {
                string[] items = item.Split(' ');
                //string item2 = Char.ToString(item[2]);
                //string item1 = Char.ToString(item[1]);
                double JustPrice = double.Parse(items[2]);
                double JustQuantity = double.Parse(items[1]);
                //double ChangingQuantitytoDouble = (double)ModifyShoppingCartPrices[1];
                //double ChangingPricetoDouble = (double)ModifyShoppingCartPrices[2];
                double SubtotalofCart = JustPrice * JustQuantity;
                //change to plus equal to have running total
                SubTotal += SubtotalofCart;  
            }
            return SubTotalS = SubTotal.ToString();
        }

        public static string TaxingSales(ArrayList arrayList)
        {
            string SalesTax = "";
            foreach (string item in arrayList)
            {
                string[] items = item.Split(' ');
                double JustPrice = double.Parse(items[2]);
                double JustQuantity = double.Parse(items[1]);
                //double ChangingQuantitytoDouble = (double)ModifyShoppingCartPrices[1];
                //double ChangingPricetoDouble = (double)ModifyShoppingCartPrices[2];
                double total = double.Parse(SubTotalCart(Product.ShoppingCart));
                double Tax = total * .06;
                double salesTax = Math.Round(Tax, 2);

                SalesTax = salesTax.ToString();
            }
            return SalesTax;
        }
        public static string GrandTotalofCart(ArrayList arrayList)
        {
            string GrandTotal = "";
            foreach (string item in arrayList)
            {
                string[] items = item.Split(' ');
                double JustPrice = double.Parse(items[2]);
                double JustQuantity = double.Parse(items[1]);
                //double ChangingQuantitytoDouble = (double)ModifyShoppingCartPrices[1];
                //double ChangingPricetoDouble = (double)ModifyShoppingCartPrices[2];
                double total = double.Parse(SubTotalCart(Product.ShoppingCart));
                double salesTax = total * .06;
                double total2 = total + salesTax;

                GrandTotal = total2.ToString();
            }
            return GrandTotal;
        }

		//public static void CheckoutM()
		//{
  //          Console.Write($"Your total is : ");

            

  //          foreach (string item in Product.ShoppingCart)
  //          {           
  //              ArrayList ModifyShoppingCartPrices= new ArrayList();              
  //              Console.WriteLine(item);
                
  //              string[] items = item.Split(' ');
  //              double JustPrice = double.Parse(items[2]);
  //              double JustQuantity = double.Parse(items[1]);
  //              //double ChangingQuantitytoDouble = (double)ModifyShoppingCartPrices[1];
  //              //double ChangingPricetoDouble = (double)ModifyShoppingCartPrices[2];
  //              double SubtotalofCart= JustPrice*JustQuantity;
  //              double SalesTax = SubtotalofCart * .06;

  //          }

  //          Console.WriteLine("--- Receipt ---");
  //          foreach (string item in Product.ShoppingCart)
  //          {
  //              //Console.WriteLine
  //              //(
  //              //    "",
  //              //    itemValue,
  //              //    itemKey,
  //              //    [itemKey],
  //              //    itemValue * [itemKey]
  //              //);
  //          }
  //          //double subTotal = calculateSubTotal(Product.ShoppingCart);
  //          //double salesTax = calculateSalesTax(Product.ShoppingCart);
  //          //double total = calculateTotal(Product.ShoppingCart);

  //          Console.WriteLine("Thank you for shopping with us!");

  //      }
  //      public static void ReturntoShop()
  //      {

  //      }
    }
}
