using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    class Total_Calc
    {
        public static void Payment()
        {
            bool move = true;
            while (move)
            {
                Console.WriteLine("Do you want to pay with Cash, Credit Card, or Venmo?");
                string input = Console.ReadLine().ToLower();

                if (!Validator.IntChecker(input) || !Validator.SpaceEnterChecker(input))
                {
                    if(input == "cash")
                    {
                        PayCash();
                    }
                    else if (input == "credit card")
                    {
                        PayCredit();
                    }
                    else if (input == "venmo")
                    {
                        PayVenmo();
                    }
                    else
                    {
                        Console.WriteLine("Was not able to verify that choice. We'll try again.");
                        continue;
                    }
                    move = false;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }
        }
        public static void PayCash()
        {
            Console.WriteLine("Great you are paying with cash!");
            bool cash = true;
            while (cash)
            {
                Console.WriteLine("How much cash are you inserting?");
                string CashInserted = Console.ReadLine();
                //int CashInsertedNum = Int32.Parse(CashInserted);

                if (Validator.DoubleChecker(CashInserted))
                {
                    bool enough = true;
                    while (enough)
                    {
                        Console.WriteLine($"Thanks, you inserted {CashInserted}.");
                        double Cash = double.Parse(CashInserted);
                        double SubTotal = double.Parse(Checkout.SubTotalCart(Product.ShoppingCart));
                        double Tax = double.Parse(Checkout.TaxingSales(Product.ShoppingCart));
                        double Totalz = double.Parse(Checkout.GrandTotalofCart(Product.ShoppingCart));
                        double Total = Math.Round(Totalz, 2);
                        double Change = Cash - Total;
                        Console.WriteLine("\n\n\nBelow will be the name of the item in your shopping cart, then the quantity of said item, and finally the price you are buying said item at.");
                        foreach (string item in Product.ShoppingCart)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine($"Tax on your items was {Tax}.");
                        Console.WriteLine($"Item cost plus tax on items leaves you with a grand total of {Total}.");

                        if (Change < 0)
                        {
                            Console.WriteLine($"Insufficient amount! Please insert at least {Total}.");
                            enough = false;
                            cash = true;
                        }
                        else if (Change >= 0)
                        {
                            Console.WriteLine($"Your change is {Change}.");
                            Console.WriteLine("Have a great day!");
                            enough = false;
                            cash = false;
                        }
                    }
                }
                else if (!Validator.IntChecker(CashInserted))
                {
                    Console.WriteLine("Sorry that was not a number.");
                    Console.WriteLine("Please try again");
                }
                else
                {
                    Console.WriteLine("Sorry I didn't get that.");
                    Console.WriteLine("Please try again");
                }
            }
        }

        public static void PayCredit()
        {
            //Regex ValidateFullCardNumber = new Regex(@"^[0 - 9]{ 16}$");
            //Regex ValidateExpiration = new Regex(@"(0[1-9]|1[12])[/](09|[1-9][9])");
            //Regex ValidateCardBack = new Regex(@"^\d{3}$");
            bool move = true;
            while (move)
            {
                Console.Write("Please enter a valid card number: ");
                string CardNumber = Console.ReadLine();

                //int num;
                //int.TryParse(input, out num);

                if (Validator.CreditCardNumberChecker(CardNumber))
                {
                    Console.Write("Please enter the expiration date on the card: ");
                    string ExpDate = Console.ReadLine();

                    if (Validator.CreditCardExpirationChecker(ExpDate))
                    {
                        Console.Write("Please enter the CVV on the back of the card: ");
                        string CVV = Console.ReadLine();

                        if (Validator.CreditCardCVVChecker(CVV))
                        {
                            Console.WriteLine("Thanks!");
                            double SubTotal = double.Parse(Checkout.SubTotalCart(Product.ShoppingCart));
                            double Taxz = double.Parse(Checkout.TaxingSales(Product.ShoppingCart));
                            double Tax = Math.Round(Taxz, 2);
                            double Totalz = double.Parse(Checkout.GrandTotalofCart(Product.ShoppingCart));
                            double Total = Math.Round(Totalz,2);
                            Console.WriteLine("\n\n\nBelow will be the name of the item in your shopping cart, then the quantity of said item, and finally the price you are buying said item at.");
                            foreach (string item in Product.ShoppingCart)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine($"Tax on your items was {Tax}.");
                            Console.WriteLine($"Item cost plus tax on items leaves you with a grand total of {Total}.");
                            Console.WriteLine($"You will be charged {Total}. ");
                            Console.WriteLine("One moment");
                            Console.WriteLine("1");
                            Console.WriteLine("2");
                            Console.WriteLine("3");
                            Console.WriteLine($"Successfully charged {Total}");
                        }
                        else
                        {
                            Console.WriteLine("Not a valid CVV");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not a valid expiration date");
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid card number");

                }
            }
        }

        public static void PayVenmo()
        {
            //Regex ValidateVenmoUN = new Regex("^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");

            Console.WriteLine("Great you are paying with Venmo!");
            bool move = true;
            while (move)
            {
                Console.WriteLine("What is your venmo username?");
                string VenmoUsername = Console.ReadLine();


                if (Validator.VenmoUserNameChecker(VenmoUsername))
                {
                    double SubTotal = double.Parse(Checkout.SubTotalCart(Product.ShoppingCart));
                    double Taxz = double.Parse(Checkout.TaxingSales(Product.ShoppingCart));
                    double Tax = Math.Round(Taxz, 2);
                    double Totalz = double.Parse(Checkout.GrandTotalofCart(Product.ShoppingCart));
                    double Total = Math.Round(Totalz, 2);
                    Console.WriteLine("\n\n\nBelow will be the name of the item in your shopping cart, then the quantity of said item, and finally the price you are buying said item at.");
                    foreach (string item in Product.ShoppingCart)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine($"Tax on your items was {Tax}.");
                    Console.WriteLine($"Item cost plus tax on items leaves you with a grand total of {Total}.");
                    Console.WriteLine($"You will be charged {Total}. ");
                    Console.WriteLine("One moment");
                    Console.WriteLine("1");
                    Console.WriteLine("2");
                    Console.WriteLine("3");
                    Console.WriteLine($"Successfully charged {Total} to {VenmoUsername}. Have a great day!");
                    move = false;
                }
                else
                {
                    Console.WriteLine("Sorry invalid username.");
                    Console.WriteLine("Please try again");
                }
            }
        }
    }
}
