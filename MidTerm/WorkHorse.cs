using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    class WorkHorse
    {
        public static void MainWork()
        {
            //Inventory.OverrideBeveragesStock(5, 10);

            Console.WriteLine("Hello!  Welcome Ran Groceries!");
            Console.WriteLine();
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine();

            bool truth = true;
            while (truth)
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
                        //for (int i = 0; i < Inventory.Products.Count; i++)
                        //{
                        //    Console.WriteLine(Inventory.GrabDairy(i)); 
                        //}
                        Console.WriteLine(Inventory.GrabDairy(1));
                        Console.WriteLine(Inventory.GrabDairy(2));
                        Console.WriteLine(Inventory.GrabDairy(3));
                        string DairyChoice = Console.ReadLine().ToLower();

                        if (DairyChoice == "1" || DairyChoice == "butter")
                        {
                            //Console.WriteLine($"You added {DairyChoice} to your cart");
                            //(add butter to cart)
                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabDairyName(1)} would you like?");
                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantityNum = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabDairyName(1), quantity, Inventory.GrabDairyPrice(1));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabDairyName(1)}\n\n");
                                    //Code below is if we have to have a running total for the cart. just gonna have to copy into all
                                    //  the other spots
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));
                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
                        }
                        else if (DairyChoice == "2" || DairyChoice == "Cheese")
                        {
                            //Console.WriteLine($"You added {DairyChoice} to your cart");
                            //(add cheese to cart)

                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabDairyName(2)} would you like?");

                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantity = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabDairyName(2), quantity, Inventory.GrabDairyPrice(2));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabDairyName(2)}\n\n");
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));

                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
                        }
                        else if (DairyChoice == "3" || DairyChoice == "Milk")
                        {
                            //Console.WriteLine($"You added {DairyChoice} to your cart");
                            //(add milk to cart)

                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabDairyName(3)} would you like?");

                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantity = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabDairyName(3), quantity, Inventory.GrabDairyPrice(3));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabDairyName(3)}\n\n");
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));

                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
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
                        Console.WriteLine(Inventory.GrabProduce(1));
                        Console.WriteLine(Inventory.GrabProduce(2));
                        Console.WriteLine(Inventory.GrabProduce(3));
                        string ProduceChoice = Console.ReadLine().ToLower();

                        if (ProduceChoice == "1" || ProduceChoice == "apple")
                        {
                            //Console.WriteLine($"You added {ProduceChoice} to your cart");
                            //(add apple to cart)

                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabProduceName(1)} would you like?");

                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantity = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabProduceName(1), quantity, Inventory.GrabProducePrice(1));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabProduceName(1)}\n\n");
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));

                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
                        }
                        else if (ProduceChoice == "2" || ProduceChoice == "Pear")
                        {
                            //Console.WriteLine($"You added {ProduceChoice} to your cart");
                            //(add Pear to cart)

                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabProduceName(2)} would you like?");

                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantity = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabProduceName(2), quantity, Inventory.GrabProducePrice(2));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabProduceName(2)}\n\n");
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));

                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
                        }
                        else if (ProduceChoice == "3" || ProduceChoice == "Banana")
                        {
                            //Console.WriteLine($"You added {ProduceChoice} to your cart");
                            //(add banana to cart)

                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabProduceName(3)} would you like?");

                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantity = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabProduceName(3), quantity, Inventory.GrabProducePrice(3));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabProduceName(3)}\n\n");
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));

                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
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
                        Console.WriteLine(Inventory.GrabMeats(1));
                        Console.WriteLine(Inventory.GrabMeats(2));
                        Console.WriteLine(Inventory.GrabMeats(3));
                        string MeatChoice = Console.ReadLine().ToLower();

                        if (MeatChoice == "1" || MeatChoice == "chicken breast" || MeatChoice == "chicken")
                        {
                            //Console.WriteLine($"You added {MeatChoice} to your cart");
                            //(add chicken breast to cart)

                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabMeatsName(1)} would you like?");

                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantity = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabMeatsName(1), quantity, Inventory.GrabMeatsPrice(1));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabMeatsName(1)}\n\n");
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));

                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
                        }
                        else if (MeatChoice == "2" || MeatChoice == "filet mignon" || MeatChoice == "filet")
                        {
                            //Console.WriteLine($"You added {MeatChoice} to your cart");
                            //(add filet mignon to cart)

                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabMeatsName(2)} would you like?");

                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantity = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabMeatsName(2), quantity, Inventory.GrabMeatsPrice(2));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabMeatsName(2)}\n\n");
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));

                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
                        }
                        else if (MeatChoice == "3" || MeatChoice == "ground beef" || MeatChoice == "beef")
                        {
                            //Console.WriteLine($"You added {MeatChoice} to your cart");
                            //(add ground beef to cart)

                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabMeatsName(3)} would you like?");

                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantity = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabMeatsName(3), quantity, Inventory.GrabMeatsPrice(3));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabMeatsName(3)}\n\n");
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));

                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
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
                        Console.WriteLine(Inventory.GrabSnacks(1));
                        Console.WriteLine(Inventory.GrabSnacks(2));
                        Console.WriteLine(Inventory.GrabSnacks(3));
                        string SnackChoice = Console.ReadLine().ToLower();

                        if (SnackChoice == "1" || SnackChoice == "chips")
                        {
                            //Console.WriteLine($"You added {SnackChoice} to your cart");
                            //(add chips to cart)

                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabSnacksName(1)} would you like?");
                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantity = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabSnacksName(1), quantity, Inventory.GrabSnacksPrice(1));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabSnacksName(1)}\n\n");
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));

                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
                        }
                        else if (SnackChoice == "2" || SnackChoice == "cookies" || SnackChoice == "cookie")
                        {
                            //Console.WriteLine($"You added {SnackChoice} to your cart");
                            //(add filet cookies to cart)

                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabSnacksName(2)} would you like?");

                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantity = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabSnacksName(2), quantity, Inventory.GrabSnacksPrice(2));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabSnacksName(2)}\n\n");
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));

                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
                        }
                        else if (SnackChoice == "3" || SnackChoice == "granola bar" || SnackChoice == "granola")
                        {
                            //Console.WriteLine($"You added {SnackChoice} to your cart");
                            //(add granola bar to cart)

                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabSnacksName(3)} would you like?");

                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantity = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabSnacksName(3), quantity, Inventory.GrabSnacksPrice(3));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabSnacksName(3)}\n\n");
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));

                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
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
                        Console.WriteLine(Inventory.GrabBeverages(1));
                        Console.WriteLine(Inventory.GrabBeverages(2));
                        Console.WriteLine(Inventory.GrabBeverages(3));
                        string BeverageChoice = Console.ReadLine().ToLower();

                        if (BeverageChoice == "1" || BeverageChoice == "water")
                        {
                            //Console.WriteLine($"You added {BeverageChoice} to your cart");
                            //(add water to cart)

                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabBeveragesName(1)} would you like?");

                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantity = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabBeveragesName(1), quantity, Inventory.GrabBeveragesPrice(1));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabBeveragesName(1)}\n\n");
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));

                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
                        }
                        else if (BeverageChoice == "2" || BeverageChoice == "tea")
                        {
                            //Console.WriteLine($"You added {BeverageChoice} to your cart");
                            //(add tea cookies to cart)

                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabBeveragesName(2)} would you like?");

                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantity = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabBeveragesName(2), quantity, Inventory.GrabBeveragesPrice(2));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabBeveragesName(2)}\n\n");
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));

                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
                        }
                        else if (BeverageChoice == "3" || BeverageChoice == "gatorade")
                        {
                            //Console.WriteLine($"You added {BeverageChoice} to your cart");
                            //(add gatorade to cart)

                            bool move = true;
                            while (move)
                            {
                                Console.WriteLine($"\n\nHow many {Inventory.GrabBeveragesName(3)} would you like?");

                                string quantity = Console.ReadLine();
                                if (Validator.IntChecker(quantity))
                                {
                                    //int quantity = int.Parse(quantity);
                                    Product.RunningCart(Inventory.GrabBeveragesName(3), quantity, Inventory.GrabBeveragesPrice(3));
                                    Console.WriteLine($"\n\nSuccessfully added {quantity}: {Inventory.GrabBeveragesName(3)}\n\n");
                                    Console.WriteLine(Checkout.LineTotal(Product.ShoppingCart));

                                    move = false;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number, try again!");
                                    continue;
                                }
                            }
                            bool movein = Continue();
                            if (movein)
                            {
                                ItemChoice = false;
                                truth = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (!movein)
                            {
                                ItemChoice = false;
                                truth = false;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("All items on your shopping cart is below");
                                foreach (string prod in Product.ShoppingCart)
                                {
                                    Console.WriteLine(prod);
                                }
                                Total_Calc.Payment();

                            }
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
        public static bool Continue()
        {
            while (true)
            {
                Console.Write("Do you want to keep adding things to your shopping cart?(Y) Or do you want to show your shopping cart and proceed to checkout?(N) (Enter Y/N): ");

                string jump = Console.ReadLine().ToUpper();

                if (jump == "N")
                {
                    return false;
                }
                else if (jump == "Y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Input was not \"y\" or \"n\"! Please try again!");
                    continue;
                }
            }
        }
    }
}
