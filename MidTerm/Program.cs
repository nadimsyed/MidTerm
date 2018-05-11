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
            //Inventory.OverrideBeveragesStock(5, 10);

            Console.WriteLine("Hello!  Welcome Ran Groceries!");
            Console.WriteLine();
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine();

            while (true)
            {
                bool ItemChoice = true;

                Console.WriteLine("Please select a category below");
                Console.WriteLine("1. Dairy");
                Console.WriteLine("2. Produce");
                Console.WriteLine("3. Meats");
                Console.WriteLine("4. Snacks");
                Console.WriteLine("5. Beverages");
                string CategorySelect = Console.ReadLine().ToLower();

                if (CategorySelect == "1" || CategorySelect == "dairy")
                {
                    while (ItemChoice)
                    {
                        Console.WriteLine("Please select an item below:");
                        Console.WriteLine();
                        Console.WriteLine("1. Butter $2.79"); //Filler text for right now
                        Console.WriteLine("2. Cheese $2.99");
                        Console.WriteLine("3. Milk $1.19");
                        string DairyChoice = Console.ReadLine().ToLower();

                        if (DairyChoice == "1" || DairyChoice == "butter")
                        {
                            Console.WriteLine($"You added {DairyChoice} to your cart");
                            //(add butter to cart)

                            ItemChoice = false;
                        }
                        else if (DairyChoice == "2" || DairyChoice == "Cheese")
                        {
                            Console.WriteLine($"You added {DairyChoice} to your cart");
                            //(add cheese to cart)

                            ItemChoice = false;
                        }
                        else if (DairyChoice == "3" || DairyChoice == "Milk")
                        {
                            Console.WriteLine($"You added {DairyChoice} to your cart");
                            //(add milk to cart)

                            ItemChoice = false;
                        }
                        else
                        {
                            Console.WriteLine("Sorry that was not a valid item, please try again");
                        }
                    }
                }
                else if (CategorySelect == "2" || CategorySelect == "produce")
                {
                    while (ItemChoice)
                    {
                        Console.WriteLine("Please select an item below:");
                        Console.WriteLine();
                        Console.WriteLine("1. Apple $1.99"); //Filler text for right now
                        Console.WriteLine("2. Pear $2.50");
                        Console.WriteLine("3. Banana $0.49");
                        string ProduceChoice = Console.ReadLine().ToLower();

                        if (ProduceChoice == "1" || ProduceChoice == "apple")
                        {
                            Console.WriteLine($"You added {ProduceChoice} to your cart");
                            //(add apple to cart)

                            ItemChoice = false;
                        }
                        else if (ProduceChoice == "2" || ProduceChoice == "Pear")
                        {
                            Console.WriteLine($"You added {ProduceChoice} to your cart");
                            //(add Pear to cart)

                            ItemChoice = false;
                        }
                        else if (ProduceChoice == "3" || ProduceChoice == "Banana")
                        {
                            Console.WriteLine($"You added {ProduceChoice} to your cart");
                            //(add banana to cart)

                            ItemChoice = false;
                        }
                        else
                        {
                            Console.WriteLine("Sorry that was not a valid item, please try again");
                        }
                    }

                }
                else if (CategorySelect == "3" || CategorySelect == "meats" || CategorySelect == "meat")
                {
                    while (ItemChoice)
                    {
                        Console.WriteLine("Please select an item below:");
                        Console.WriteLine();
                        Console.WriteLine("1. Chicken Breast $ 9.99"); //Filler text for right now
                        Console.WriteLine("2. Filet Mignon $19.99");
                        Console.WriteLine("3. Ground Beef $ 6.49");
                        string MeatChoice = Console.ReadLine().ToLower();

                        if (MeatChoice == "1" || MeatChoice == "chicken breast" || MeatChoice == "chicken")
                        {
                            Console.WriteLine($"You added {MeatChoice} to your cart");
                            //(add chicken breast to cart)

                            ItemChoice = false;
                        }
                        else if (MeatChoice == "2" || MeatChoice == "filet mignon" || MeatChoice == "filet")
                        {
                            Console.WriteLine($"You added {MeatChoice} to your cart");
                            //(add filet mignon to cart)

                            ItemChoice = false;
                        }
                        else if (MeatChoice == "3" || MeatChoice == "ground beef" || MeatChoice == "beef")
                        {
                            Console.WriteLine($"You added {MeatChoice} to your cart");
                            //(add ground beef to cart)

                            ItemChoice = false;
                        }
                        else
                        {
                            Console.WriteLine("Sorry that was not a valid item, please try again");
                        }
                    }

                }
                else if (CategorySelect == "4" || CategorySelect == "snacks" || CategorySelect == "snack")
                {
                    while (ItemChoice)
                    {
                        Console.WriteLine("Please select an item below:");
                        Console.WriteLine();
                        Console.WriteLine("1. Chips $0.99"); //Filler text for right now
                        Console.WriteLine("2. Cookies $1.50");
                        Console.WriteLine("3. Granola Bar $0.49");
                        string SnackChoice = Console.ReadLine().ToLower();

                        if (SnackChoice == "1" || SnackChoice == "chips")
                        {
                            Console.WriteLine($"You added {SnackChoice} to your cart");
                            //(add chips to cart)

                            ItemChoice = false;
                        }
                        else if (SnackChoice == "2" || SnackChoice == "cookies" || SnackChoice == "cookie")
                        {
                            Console.WriteLine($"You added {SnackChoice} to your cart");
                            //(add filet cookies to cart)

                            ItemChoice = false;
                        }
                        else if (SnackChoice == "3" || SnackChoice == "granola bar" || SnackChoice == "granola")
                        {
                            Console.WriteLine($"You added {SnackChoice} to your cart");
                            //(add granola bar to cart)

                            ItemChoice = false;
                        }
                        else
                        {
                            Console.WriteLine("Sorry that was not a valid item, please try again");
                        }
                    }

                }
                else if (CategorySelect == "5" || CategorySelect == "beverages" || CategorySelect == "beverage")
                {
                    while (ItemChoice)
                    {
                        Console.WriteLine("Please select an item below:");
                        Console.WriteLine();
                        Console.WriteLine("1. Water $0.99"); //Filler text for right now
                        Console.WriteLine("2. Tea $1.09");
                        Console.WriteLine("3. Gatorade $1.49");
                        string BeverageChoice = Console.ReadLine().ToLower();

                        if (BeverageChoice == "1" || BeverageChoice == "water")
                        {
                            Console.WriteLine($"You added {BeverageChoice} to your cart");
                            //(add water to cart)

                            ItemChoice = false;
                        }
                        else if (BeverageChoice == "2" || BeverageChoice == "tea")
                        {
                            Console.WriteLine($"You added {BeverageChoice} to your cart");
                            //(add tea cookies to cart)

                            ItemChoice = false;
                        }
                        else if (BeverageChoice == "3" || BeverageChoice == "gatorade")
                        {
                            Console.WriteLine($"You added {BeverageChoice} to your cart");
                            //(add gatorade to cart)

                            ItemChoice = false;
                        }
                        else
                        {
                            Console.WriteLine("Sorry that was not a valid item, please try again");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Sorry that was not an option");
                }
            }
        }
    }
}
