using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    class Inventory
    {
        private static ArrayList products = new ArrayList();

        public static ArrayList Products { get => products; set => products = value; }

        public static void AddItem()
        {
            bool truth = true;
            while (truth)
            {
                int attempts = 0;
                Console.WriteLine("Do you want to add an item to the inventory? (Y/N)");
                string input = Console.ReadLine().ToLower();
                if (!Validator.IntChecker(input) && !Validator.SpaceEnterChecker(input))
                {
                    if (input == "y")
                    {
                        Console.Write("Admin, please enter the password to get authorization: ");
                        string password = Console.ReadLine();
                        if (password == "Test")
                        {
                            Console.WriteLine("Password confirmed");
                            bool select = true;
                            while (select)
                            {
                                Console.WriteLine("Choose the category you want to add to from the selection below");
                                Console.WriteLine("1. Dairy");
                                Console.WriteLine("2. Produce");
                                Console.WriteLine("3. Meats");
                                Console.WriteLine("4. Snacks");
                                Console.WriteLine("5. Beverages");
                                string selection = Console.ReadLine().ToLower();
                                if (selection == "1" || selection == "dairy")
                                {
                                    AddingToTxt(@"Dairy.txt", "Dairy", DairyCount());
                                }
                                else if (selection == "2" || selection == "produce")
                                {
                                    AddingToTxt(@"Produce.txt", "Produce",ProduceCount());

                                }
                                else if (selection == "3" || selection == "meats")
                                {
                                    AddingToTxt(@"Meats.txt", "Meats", MeatsCount());

                                }
                                else if (selection == "4" || selection == "snacks")
                                {
                                    AddingToTxt(@"Snacks.txt", "Snacks", SnacksCount());

                                }
                                else if (selection == "5" || selection == "beverages")
                                {
                                    AddingToTxt(@"Beverages.txt", "Beverages",BeveragesCount());

                                }
                                else
                                {
                                    Console.WriteLine("Not a valid selection. Selection will be shown again below");
                                }
                            }
                        }
                        else if (password != "Test")
                        {
                            if (attempts == 3)
                            {
                                Console.WriteLine("Too many invalid attempts. Will send you out of admin window.");
                                truth = false; 
                            }
                            //continue;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect password. Try again!");
                            attempts++;
                        }
                    }
                    else if (input == "n")
                    {
                        Console.WriteLine("Nothing added to inventory");
                        truth = false;
                    }
                    else
                    {
                        Console.WriteLine("Could not confirm. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Let's try again!");
                }
            }
        }

        public static void AddingToTxt(string txt, string category, int inventoryCounter, int stock = 20)
        {
            //ArrayList Products = new ArrayList();
            //StreamReader sr = null;
            string itemName = "";
            string itemPrice = "";
            string itemCategory = category;
            string itemUnit = "";
            string itemDescription = "";
            int stockAmount = stock;
            int counter = 0;
            bool stage1 = true;
            while (stage1)
            {
                Console.WriteLine("Add the name of the item, one word");
                itemName = Console.ReadLine();
                if (!Validator.SpaceEnterChecker(itemName) && !Validator.IntChecker(itemName))
                {
                    stage1 = false;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            bool stage2 = true;
            while (stage2)
            {
                Console.WriteLine("Add the price of the item");
                itemPrice = Console.ReadLine();
                if (Validator.DoubleChecker(itemPrice) || Validator.IntChecker(itemPrice))
                {
                    stage2 = false;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            bool stage4 = true;
            while (stage4)
            {
                Console.WriteLine("Add the unit size of the item.");
                itemUnit = Console.ReadLine();
                //if (!Validator.SpaceEnterChecker(itemUnit)/* && Validator.IntChecker(itemUnit)*/)
                //{
                //    stage4 = false;
                //}
                //else
                //{
                //    Console.WriteLine("Invalid");
                //}
                stage4 = false;
            }
            bool stage5 = true;
            while (stage5)
            {
                Console.WriteLine("Add the description of the item");
                itemDescription = Console.ReadLine();
                if (/*!Validator.SpaceEnterChecker(itemDescription) && */!Validator.IntChecker(itemDescription))
                {
                    stage5 = false;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }

            //sr = new StreamReader(txt);

            //while (!sr.EndOfStream)
            //{
                //String line = sr.ReadLine();

                //string[] z = line.Split('\t');

                //Products.Add(z);
                //counter++;

                StreamWriter sw = null;
                try
                {
                    //tried false to but didnt work. willl have to look at how to append
                    sw = new StreamWriter(txt, true);
                    //foreach (string[] some in Products)
                    //{
                    //if (inventoryCounter <= 3)
                    //{
                    
                    //    int countDracula = 0;
                    //    foreach (string item in Product.Dairy)
                    //    {
                    //        countDracula++;
                    //        counter++;
                    //        if (countDracula == 3)
                    //        {
                    //            sw.WriteLine(item + "\t");
                    //        }
                    //        else
                    //        {
                    //            sw.Write(item + "\t");
                    //        }
                    //    }
                    //    countDracula = 0; 
                    //}
                    //}
                    //else
                    //{
                    //    int countDracula = 0;
                    //    foreach (string item in z)
                    //    {
                    //        countDracula++;
                    //    }
                    //    countDracula = 0;
                    //}
                    //if (counter == inventoryCounter)
                    //{
                        sw.Write(itemName + "\t" + itemPrice + "\t" + itemCategory + "\t" + itemUnit + "\t" + itemDescription + "\t" + stockAmount + "\t");
                    //}
                    //else
                    //{
                    //    //continue;
                    //}
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("File access denied");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please convey this error to IT. Exiting...");
                    throw;
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                }
            //}
        }

        //can change stock but makes spaces and seperates the stock spot to seperate lines
        //cannot override original file, can make a new file
        //        Water	0.99	Beverages	16.9 Fl oz  Spring water	20
        //Tea	1.10	Beverages	16.9 Fl oz  Green tea	20
        //Gatorade Beverages	1.50	20 Fl oz    Electrolytes Baby!	20

        //Figure out how to append, will have to redo the file from scratch
        public static void IncompleteAddingToTxt(string txt, string category,int inventoryCounter,int stock = 20)
        {
            ArrayList Products = new ArrayList();
            StreamReader sr = null;
            string itemName = "";
            string itemPrice = "";
            string itemCategory = category;
            string itemUnit = "";
            string itemDescription = "";
            int stockAmount = stock;
            int counter = 0;
            bool stage1 = true;
            while (stage1)
            {
                Console.WriteLine("Add the name of the item, one word");
                itemName = Console.ReadLine();
                if (!Validator.SpaceEnterChecker(itemName) && !Validator.IntChecker(itemName))
                {
                    stage1 = false;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            bool stage2 = true;
            while (stage2)
            {
                Console.WriteLine("Add the price of the item");
                itemPrice = Console.ReadLine();
                if (Validator.DoubleChecker(itemPrice) || Validator.IntChecker(itemPrice))
                {
                    stage2 = false;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            bool stage4 = true;
            while (stage4)
            {
                Console.WriteLine("Add the unit size of the item.");
                itemUnit = Console.ReadLine();
                //if (!Validator.SpaceEnterChecker(itemUnit)/* && Validator.IntChecker(itemUnit)*/)
                //{
                //    stage4 = false;
                //}
                //else
                //{
                //    Console.WriteLine("Invalid");
                //}
                stage4 = false;
            }
            bool stage5 = true;
            while (stage5)
            {
                Console.WriteLine("Add the description of the item");
                itemDescription = Console.ReadLine();
                if (/*!Validator.SpaceEnterChecker(itemDescription) && */!Validator.IntChecker(itemDescription))
                {
                    stage5 = false;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }

            sr = new StreamReader(txt);

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                counter++;

                StreamWriter sw = null;
                try
                {
                    //tried false to but didnt work. willl have to look at how to append
                    sw = new StreamWriter(txt, true);
                    foreach (string[] some in Products)
                    {
                        foreach (string item in some)
                        {
                            sw.WriteLine(item);
                        }
                    }
                    if (counter == inventoryCounter)
                    {
                        sw.WriteLine(itemName + "\t" + itemPrice + "\t" + itemCategory + "\t" + itemUnit + "\t" + itemDescription + "\t" + stockAmount + "\n"); 
                    }
                    else
                    {
                        continue;
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("File access denied");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please convey this error to IT. Exiting...");
                    throw;
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                }
            }
        }
        
        public static string GrabSnacksStock(int x)
        {
            int a = 0;
            string price = "";
            foreach (string item in Product.Snacks)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[5];

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string price = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Snacks.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        price = z[5];

            //    }
            //}
            return price;
        }

        public static string GrabBeveragesStock(int x)
        {
            int a = 0;
            string price = "";
            foreach (string item in Product.Beverages)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[5];

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string price = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Beverages.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        price = z[5];

            //    }
            //}
            return price;
        }

        public static string GrabProduceStock(int x)
        {
            int a = 0;
            string price = "";
            foreach (string item in Product.Produce)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[5];

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string price = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Produce.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        price = z[5];

            //    }
            //}
            return price;
        }

        public static string GrabMeatsStock(int x)
        {
            int a = 0;
            string price = "";
            foreach (string item in Product.Meats)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[5];

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string price = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Meats.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        price = z[5];

            //    }
            //}
            return price;
        }

        public static string GrabDairyStock(int x)
        {
            int a = 0;
            string price = "";
            foreach (string item in Product.Dairy)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[5];

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string price = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Dairy.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        price = z[5];

            //    }
            //}
            return price;
        }

        public static string GrabDairyName(int x)
        {
            int a = 0;
            string name = "";
            foreach (string item in Product.Dairy)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    name = z[0];

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string name = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Dairy.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        name = z[0];

            //    }
            //}
            return name;
        }

        public static string GrabDairyPrice(int x)
        {
            int a = 0;
            string price = "";
            foreach (string item in Product.Dairy)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[1];

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string price = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Dairy.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        price = z[1];

            //    }
            //}
            return price;
        }

        public static string GrabMeatsName(int x)
        {
            int a = 0;
            string name = "";
            foreach (string item in Product.Meats)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    name = z[0];

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string name = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Meats.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        name = z[0];

            //    }
            //}
            return name;
        }

        public static string GrabMeatsPrice(int x)
        {
            int a = 0;
            string price = "";
            foreach (string item in Product.Meats)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[1];

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string price = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Meats.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        price = z[1];

            //    }
            //}
            return price;
        }

        public static string GrabProduceName(int x)
        {
            int a = 0;
            string name = "";
            foreach (string item in Product.Produce)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    name = z[0];

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string name = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Produce.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        name = z[0];

            //    }
            //}
            return name;
        }

        public static string GrabProducePrice(int x)
        {
            int a = 0;
            string price = "";
            foreach (string item in Product.Produce)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[1];

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string price = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Produce.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        price = z[1];

            //    }
            //}
            return price;
        }

        public static string GrabSnacksName(int x)
        {
            int a = 0;
            string name = "";
            foreach (string item in Product.Snacks)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    name = z[0];

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string name = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Snacks.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        name = z[0];

            //    }
            //}
            return name;
        }

        public static string GrabSnacksPrice(int x)
        {
            int a = 0;
            string price = "";
            foreach (string item in Product.Snacks)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[1];

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string price = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Snacks.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        price = z[1];

            //    }
            //}
            return price;
        }

        public static string GrabBeveragesName(int x)
        {
            //ArrayList Products = new ArrayList();

            int a = 0;
            string name = "";
            //StreamReader sr = null;

            foreach (string item in Product.Beverages)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    name = z[0];

                }
            }
            //sr = new StreamReader("Beverages.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        name = z[0];

            //    }
            //}
            return name;
        }

        public static string GrabBeveragesPrice(int x)
        {
            //ArrayList Products = new ArrayList();

            int a = 0;
            string price = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Beverages.txt");

            //while (!sr.EndOfStream)
            //{
            //String line = sr.ReadLine();
            
            foreach (string item in Product.Beverages)
            {
                string[] z = item.Split('\t');
                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[1];

                }
            }
            //string[] z = line.Split('\t');

                //Products.Add(z);
                //a++;
                //if (a == x)
                //{
                //    price = z[1];

                //}
            
            return price;
        }

        public static string GrabBeverages(int x)
        {
            int a = 0;
            string pick = "";
            foreach (string item in Product.Beverages)
            {
                string[] z = item.Split('\t');
                a++;
                if (a == x)
                {
                    pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string pick = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Beverages.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

            //    }
            //}
            return pick;
        }

        public static int BeveragesCount()
        {
            int count = 0;
            foreach (string item in Product.Beverages)
            {
                count++;
            }
            //ArrayList Products = new ArrayList();

            //StreamReader sr = null;

            //int count = 0;
            //try
            //{
            //    sr = new StreamReader("Beverages.txt");

            //    while (!sr.EndOfStream)
            //    {
            //        String line = sr.ReadLine();

            //        string[] x = line.Split('\t');

            //        Products.Add(x);

            //        count++;

            //    }
            //    Console.WriteLine("End of file");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error reading file");
            //}
            //finally
            //{
            //    if (sr != null)
            //    {
            //        sr.Close();
            //    }
            //}
            return count;
        }

        public static void BeveragesRead()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Beverages.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string x = line;

                    Product.Beverages.Add(x);

                }
            }

            catch (Exception)
            {
                Console.WriteLine("Error reading file");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        public static void Beverages()
        {
            foreach (string item in Product.Beverages)
            {
                string[] x = item.Split('\t');
                Console.Write("item: " + x[0] + "\t");
                Console.Write("price: " + x[1] + "\t");
                Console.Write("category: " + x[2] + "\t");
                Console.Write("unit size: " + x[3] + "\t");
                Console.WriteLine("description: " + x[4] + "\t");
            }
            //ArrayList Products = new ArrayList();

            //StreamReader sr = null;
            //try
            //{
            //    sr = new StreamReader("Beverages.txt");

            //    while (!sr.EndOfStream)
            //    {
            //        String line = sr.ReadLine();

            //        string[] x = line.Split('\t');

            //        Products.Add(x);

            //        /*
            //        if (line == null)
            //        {
            //            Console.WriteLine("End of file");
            //            return;
            //        }
            //        */
            //        //Console.WriteLine("read: " + line);
            //        Console.Write("item: " + x[0] + "\t");
            //        Console.Write("price: " + x[1] + "\t");
            //        Console.Write("category: " + x[2] + "\t");
            //        Console.Write("unit size: " + x[3] + "\t");
            //        Console.WriteLine("description: " + x[4] + "\t");
            //    }
            //    Console.WriteLine("End of file");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error reading file");
            //}
            //finally
            //{
            //    if (sr != null)
            //    {
            //        sr.Close();
            //    }
            //}
        }

        public static string GrabSnacks(int x)
        {
            int a = 0;
            string pick = "";
            foreach (string item in Product.Snacks)
            {
                string[] z = item.Split('\t');
                a++;
                if (a == x)
                {
                    pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string pick = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Snacks.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

            //    }
            //}
            return pick;
        }

        public static int SnacksCount()
        {
            int count = 0;
            foreach (string item in Product.Snacks)
            {
                count++;
            }
            //ArrayList Products = new ArrayList();

            //StreamReader sr = null;

            //int count = 0;
            //try
            //{
            //    sr = new StreamReader("Snacks.txt");

            //    while (!sr.EndOfStream)
            //    {
            //        String line = sr.ReadLine();

            //        string[] x = line.Split('\t');

            //        Products.Add(x);

            //        count++;

            //    }
            //    Console.WriteLine("End of file");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error reading file");
            //}
            //finally
            //{
            //    if (sr != null)
            //    {
            //        sr.Close();
            //    }
            //}
            return count;
        }

        public static void SnacksRead()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Snacks.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string x = line;

                    Product.Snacks.Add(x);

                }
            }

            catch (Exception)
            {
                Console.WriteLine("Error reading file");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        public static void Snacks()
        {
            foreach (string item in Product.Snacks)
            {
                string[] x = item.Split('\t');
                Console.Write("item: " + x[0] + "\t");
                Console.Write("price: " + x[1] + "\t");
                Console.Write("category: " + x[2] + "\t");
                Console.Write("unit size: " + x[3] + "\t");
                Console.WriteLine("description: " + x[4] + "\t");
            }
            //ArrayList Products = new ArrayList();

            //StreamReader sr = null;
            //try
            //{
            //    sr = new StreamReader("Snacks.txt");

            //    while (!sr.EndOfStream)
            //    {
            //        String line = sr.ReadLine();

            //        string[] x = line.Split('\t');

            //        Products.Add(x);

            //        /*
            //        if (line == null)
            //        {
            //            Console.WriteLine("End of file");
            //            return;
            //        }
            //        */
            //        //Console.WriteLine("read: " + line);
            //        Console.Write("item: " + x[0] + "\t");
            //        Console.Write("price: " + x[1] + "\t");
            //        Console.Write("category: " + x[2] + "\t");
            //        Console.Write("unit size: " + x[3] + "\t");
            //        Console.WriteLine("description: " + x[4] + "\t");
            //    }
            //    Console.WriteLine("End of file");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error reading file");
            //}
            //finally
            //{
            //    if (sr != null)
            //    {
            //        sr.Close();
            //    }
            //}
        }

        public static string GrabProduce(int x)
        {
            int a = 0;
            string pick = "";
            foreach (string item in Product.Produce)
            {
                string[] z = item.Split('\t');
                a++;
                if (a == x)
                {
                    pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

                }
            }
            //ArrayList Products = new ArrayList();

            //int a = 0;
            //string pick = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Produce.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

            //    }
            //}
            return pick;
        }

        public static int ProduceCount()
        {
            int count = 0;
            foreach (string item in Product.Produce)
            {
                count++;
            }
            //ArrayList Products = new ArrayList();

            //StreamReader sr = null;

            //int count = 0;
            //try
            //{
            //    sr = new StreamReader("Produce.txt");

            //    while (!sr.EndOfStream)
            //    {
            //        String line = sr.ReadLine();

            //        string[] x = line.Split('\t');

            //        Products.Add(x);

            //        count++;

            //    }
            //    Console.WriteLine("End of file");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error reading file");
            //}
            //finally
            //{
            //    if (sr != null)
            //    {
            //        sr.Close();
            //    }
            //}
            return count;
        }

        public static void ProduceRead()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Produce.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string x = line;

                    Product.Produce.Add(x);

                }
            }

            catch (Exception)
            {
                Console.WriteLine("Error reading file");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        public static void Produce()
        {
            //ArrayList Products = new ArrayList();

            //StreamReader sr = null;
            //try
            //{
            //    sr = new StreamReader("Produce.txt");

            //    while (!sr.EndOfStream)
            //    {
            //        String line = sr.ReadLine();

            //        string[] x = line.Split('\t');

            //        Products.Add(x);

            //        /*
            //        if (line == null)
            //        {
            //            Console.WriteLine("End of file");
            //            return;
            //        }
            //*/
            //Console.WriteLine("read: " + line);
            //Console.Write("item: " + x[0] + "\t");
            //Console.Write("price: " + x[1] + "\t");
            //Console.Write("category: " + x[2] + "\t");
            //Console.Write("unit size: " + x[3] + "\t");
            //Console.WriteLine("description: " + x[4] + "\t");
            foreach (string item in Product.Produce)
            {
                string[] x = item.Split('\t');
                Console.Write("item: " + x[0] + "\t");
                Console.Write("price: " + x[1] + "\t");
                Console.Write("category: " + x[2] + "\t");
                Console.Write("unit size: " + x[3] + "\t");
                Console.WriteLine("description: " + x[4] + "\t");
            }
            //    }
            //    Console.WriteLine("End of file");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error reading file");
            //}
            //finally
            //{
            //    if (sr != null)
            //    {
            //        sr.Close();
            //    }
            //}
        }

        public static string GrabMeats(int x)
        {
            //ArrayList Products = new ArrayList();

            int a = 0;
            string pick = "";
            foreach (string item in Product.Meats)
            {
                string[] z = item.Split('\t');
                a++;
                if (a == x)
                {
                    pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

                }
            }
            //StreamReader sr = null;

            //sr = new StreamReader("Meats.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] z = line.Split('\t');

            //    Products.Add(z);
            //    a++;
            //    if (a == x)
            //    {
            //        pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

            //    }
            //}
            return pick;
        }

        public static int MeatsCount()
        {
            //ArrayList Products = new ArrayList();

            //StreamReader sr = null;

            int count = 0;
            foreach (string item in Product.Meats)
            {
                count++;
            }
            //try
            //{
            //    sr = new StreamReader("Meats.txt");

            //    while (!sr.EndOfStream)
            //    {
            //        String line = sr.ReadLine();

            //        string[] x = line.Split('\t');

            //        Products.Add(x);

            //        count++;

            //    }
            //    Console.WriteLine("End of file");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error reading file");
            //}
            //finally
            //{
            //    if (sr != null)
            //    {
            //        sr.Close();
            //    }
            //}
            return count;
        }

        public static void MeatsRead()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Meats.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string x = line;

                    Product.Meats.Add(x);

                }
            }

            catch (Exception)
            {
                Console.WriteLine("Error reading file");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        public static void Meats()
        {
            //ArrayList Products = new ArrayList();

            //StreamReader sr = null;
            //try
            //{
            //    sr = new StreamReader("Meats.txt");

            //    while (!sr.EndOfStream)
            //    {
            //        String line = sr.ReadLine();

            //        string[] x = line.Split('\t');

            //        Products.Add(x);

            /*
            if (line == null)
            {
                Console.WriteLine("End of file");
                return;
            }
            */
            //Console.WriteLine("read: " + line);
            //Console.Write("item: " + x[0] + "\t");
            //Console.Write("price: " + x[1] + "\t");
            //Console.Write("category: " + x[2] + "\t");
            //Console.Write("unit size: " + x[3] + "\t");
            //Console.WriteLine("description: " + x[4] + "\t");
            foreach (string item in Product.Meats)
            {
                string[] x = item.Split('\t');
                Console.Write("item: " + x[0] + "\t");
                Console.Write("price: " + x[1] + "\t");
                Console.Write("category: " + x[2] + "\t");
                Console.Write("unit size: " + x[3] + "\t");
                Console.WriteLine("description: " + x[4] + "\t");
            }
            //    }
            //    Console.WriteLine("End of file");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error reading file");
            //}
            //finally
            //{
            //    if (sr != null)
            //    {
            //        sr.Close();
            //    }
            //}
        }

        public static string GrabDairy(int x)
        {
            //ArrayList Products = new ArrayList();

            int a = 0;
            string pick = "";
            //StreamReader sr = null;

            //sr = new StreamReader("Dairy.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();
            foreach (string item in Product.Dairy)
            {
                string[] z = item.Split('\t');
                a++;
                if (a == x)
                {
                    pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

                }
            }
            //string[] z = line.Split('\t');
                
                //Products.Add(z);
                //a++;
                //if(a == x)
                //{
                //    pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

                //}
            
            return pick;
        }

        public static int DairyCount()
        {
            //ArrayList Products = new ArrayList();

            //StreamReader sr = null;

            int count = 0;
            //try
            //{
            //    sr = new StreamReader("Dairy.txt");

            //    while (!sr.EndOfStream)
            //    {
            //String line = sr.ReadLine();

            //string[] x = line.Split('\t');

            //Products.Add(x);
            foreach (string item in Product.Dairy)
            {
                count++;
            }
            //    }
            //    Console.WriteLine("End of file");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error reading file");
            //}
            //finally
            //{
            //    if (sr != null)
            //    {
            //        sr.Close();
            //    }
            //}
            return count;
        }

        public static void DairyRead()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Dairy.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string x = line;

                    Product.Dairy.Add(x);

                }
            }
            
            catch (Exception)
            {
                Console.WriteLine("Error reading file");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        public static void Dairy()
        {
            //ArrayList Products = new ArrayList();

            //StreamReader sr = null;
            //try
            //{
            //sr = new StreamReader("Dairy.txt");

            //while (!sr.EndOfStream)
            //{
            //    String line = sr.ReadLine();

            //    string[] x = line.Split('\t');

            //Products.Add(x);

            /*
            if (line == null)
            {
                Console.WriteLine("End of file");
                return;
            }
            */
            //Console.WriteLine("read: " + line);
            foreach (string item in Product.Dairy)
            {
                string[] x = item.Split('\t');
                Console.Write("item: " + x[0] + "\t");
                Console.Write("price: " + x[1] + "\t");
                Console.Write("category: " + x[2] + "\t");
                Console.Write("unit size: " + x[3] + "\t");
                Console.WriteLine("description: " + x[4] + "\t");
            }
                    //Console.Write("item: " + x[0] + "\t");
                    //Console.Write("price: " + x[1] + "\t");
                    //Console.Write("category: " + x[2] + "\t");
                    //Console.Write("unit size: " + x[3] + "\t");
                    //Console.WriteLine("description: " + x[4] + "\t");

            //    }
            //    Console.WriteLine("End of file");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error reading file");
            //}
            //finally
            //{
            //    if (sr != null)
            //    {
            //        sr.Close();
            //    }
            //}
        }
    }
}
