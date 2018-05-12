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

        //public static void AddItem()
        //{
        //    bool truth = true;
        //    while (truth)
        //    {
        //        Console.WriteLine("Do you want to add an item to the inventory? (Y/N)");
        //        string input = Console.ReadLine().ToLower();
        //        if (!Validator.IntChecker(input) || !Validator.SpaceEnterChecker(input))
        //        {
        //            if(input == "y")
        //            {
        //                Console.Write("Admin, please enter the password to get authorization: ");
        //                string password = Console.ReadLine();
        //                if(password == "GroceryStoreGCMidTerm")
        //                {
        //                    Console.WriteLine("Password confirmed");
        //                    bool selection = true;
        //                    while (selection)
        //                    {
        //                        Console.WriteLine("Choose the category you want to add to from the selection below");
        //                        Console.WriteLine("1. Dairy");
        //                        Console.WriteLine("2. Produce");
        //                        Console.WriteLine("3. Meats");
        //                        Console.WriteLine("4. Snacks");
        //                        Console.WriteLine("5. Beverages");
        //                        string selection = Console.ReadLine().ToLower();
        //                        if (selection == "1" || selection == "dairy")
        //                        {

        //                        }
        //                        else if (selection == "2" || selection == "produce")
        //                        {

        //                        }
        //                        else if (selection == "3" || selection == "meats")
        //                        {

        //                        }
        //                        else if (selection == "4" || selection == "snacks")
        //                        {

        //                        }
        //                        else if (selection == "5" || selection == "beverages")
        //                        {

        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine("Not a valid selection. Selection will be shown again below");
        //                        } 
        //                    }
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Incorrect password");
        //                }
        //            }
        //            else if(input == "n")
        //            {
        //                Console.WriteLine("Nothing added to inventory");
        //                truth = false;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Could not confirm. Please try again.");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid input. Let's try again!");
        //        } 
        //    }
        //}

        //can change stock but makes spaces and seperates the stock spot to seperate lines
        //cannot override original file, can make a new file
//        Water	0.99	Beverages	16.9 Fl oz  Spring water	20
//Tea	1.10	Beverages	16.9 Fl oz  Green tea	20
//Gatorade Beverages	1.50	20 Fl oz    Electrolytes Baby!	20

            //Figure out how to append, will have to redo the file from scratch
        //public static void OverrideBeveragesStock(int x, int newStock)
        //{
        //    ArrayList Products = new ArrayList();

        //    int a = 0;
        //    int b = 0;
        //    string price = "";
        //    StreamReader sr = null;

        //    sr = new StreamReader("Beverages.txt");

        //    while (!sr.EndOfStream)
        //    {
        //        String line = sr.ReadLine();

        //        string[] z = line.Split('\t');

        //        Products.Add(z);
        //        //a++;
        //        //if (a == x)
        //        //{
        //        //    price = z[5];

        //        //}

        //        StreamWriter sw = null;
        //        try
        //        {
        //            sw = new StreamWriter("Beverages.txt");

        //            foreach (string name in z)
        //            {
        //                if (b == x)
        //                {
        //                    b++;
        //                    //string newStockString = newStock.ToString();
        //                    int stock = int.Parse(z[5]);
        //                    stock = newStock;
        //                    string newStockString = stock.ToString();
        //                    //z[5] = newStockString;
        //                    sw.WriteLine(newStockString);
        //                }
        //                else
        //                {
        //                    b++;
        //                    //Console.WriteLine(name);
        //                    sw.WriteLine(name);
        //                }
        //            }
        //        }
        //        catch (UnauthorizedAccessException)
        //        {
        //            Console.WriteLine("File access denied");
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //            Console.WriteLine("Please convey this error to IT. Exiting...");
        //            throw;
        //        }
        //        finally
        //        {
        //            if (sw != null)
        //            {
        //                sw.Close();
        //            }
        //        }
        //    }
        //}

        public static string GrabSnacksStock(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string price = "";
            StreamReader sr = null;

            sr = new StreamReader("Snacks.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[5];

                }
            }
            return price;
        }

        public static string GrabBeveragesStock(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string price = "";
            StreamReader sr = null;

            sr = new StreamReader("Beverages.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[5];

                }
            }
            return price;
        }

        public static string GrabProduceStock(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string price = "";
            StreamReader sr = null;

            sr = new StreamReader("Produce.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[5];

                }
            }
            return price;
        }

        public static string GrabMeatsStock(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string price = "";
            StreamReader sr = null;

            sr = new StreamReader("Meats.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[5];

                }
            }
            return price;
        }

        public static string GrabDairyStock(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string price = "";
            StreamReader sr = null;

            sr = new StreamReader("Dairy.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[5];

                }
            }
            return price;
        }

        public static string GrabDairyName(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string name = "";
            StreamReader sr = null;

            sr = new StreamReader("Dairy.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    name = z[0];

                }
            }
            return name;
        }

        public static string GrabDairyPrice(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string price = "";
            StreamReader sr = null;

            sr = new StreamReader("Dairy.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[1];

                }
            }
            return price;
        }

        public static string GrabMeatsName(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string name = "";
            StreamReader sr = null;

            sr = new StreamReader("Meats.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    name = z[0];

                }
            }
            return name;
        }

        public static string GrabMeatsPrice(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string price = "";
            StreamReader sr = null;

            sr = new StreamReader("Meats.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[1];

                }
            }
            return price;
        }

        public static string GrabProduceName(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string name = "";
            StreamReader sr = null;

            sr = new StreamReader("Produce.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    name = z[0];

                }
            }
            return name;
        }

        public static string GrabProducePrice(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string price = "";
            StreamReader sr = null;

            sr = new StreamReader("Produce.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[1];

                }
            }
            return price;
        }

        public static string GrabSnacksName(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string name = "";
            StreamReader sr = null;

            sr = new StreamReader("Snacks.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    name = z[0];

                }
            }
            return name;
        }

        public static string GrabSnacksPrice(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string price = "";
            StreamReader sr = null;

            sr = new StreamReader("Snacks.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[1];

                }
            }
            return price;
        }

        public static string GrabBeveragesName(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string name = "";
            StreamReader sr = null;

            sr = new StreamReader("Beverages.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    name = z[0];

                }
            }
            return name;
        }

        public static string GrabBeveragesPrice(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string price = "";
            StreamReader sr = null;

            sr = new StreamReader("Beverages.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    price = z[1];

                }
            }
            return price;
        }

        public static string GrabBeverages(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string pick = "";
            StreamReader sr = null;

            sr = new StreamReader("Beverages.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

                }
            }
            return pick;
        }

        public static int BeveragesCount()
        {
            ArrayList Products = new ArrayList();

            StreamReader sr = null;

            int count = 0;
            try
            {
                sr = new StreamReader("Beverages.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string[] x = line.Split('\t');

                    Products.Add(x);

                    count++;

                }
                Console.WriteLine("End of file");
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
            return count;
        }

        public static void Beverages()
        {
            ArrayList Products = new ArrayList();

            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Beverages.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string[] x = line.Split('\t');

                    Products.Add(x);

                    /*
                    if (line == null)
                    {
                        Console.WriteLine("End of file");
                        return;
                    }
                    */
                    //Console.WriteLine("read: " + line);
                    Console.Write("item: " + x[0] + "\t");
                    Console.Write("price: " + x[1] + "\t");
                    Console.Write("category: " + x[2] + "\t");
                    Console.Write("unit size: " + x[3] + "\t");
                    Console.WriteLine("description: " + x[4] + "\t");
                }
                Console.WriteLine("End of file");
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

        public static string GrabSnacks(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string pick = "";
            StreamReader sr = null;

            sr = new StreamReader("Snacks.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

                }
            }
            return pick;
        }

        public static int SnacksCount()
        {
            ArrayList Products = new ArrayList();

            StreamReader sr = null;

            int count = 0;
            try
            {
                sr = new StreamReader("Snacks.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string[] x = line.Split('\t');

                    Products.Add(x);

                    count++;

                }
                Console.WriteLine("End of file");
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
            return count;
        }

        public static void Snacks()
        {
            ArrayList Products = new ArrayList();

            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Snacks.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string[] x = line.Split('\t');

                    Products.Add(x);

                    /*
                    if (line == null)
                    {
                        Console.WriteLine("End of file");
                        return;
                    }
                    */
                    //Console.WriteLine("read: " + line);
                    Console.Write("item: " + x[0] + "\t");
                    Console.Write("price: " + x[1] + "\t");
                    Console.Write("category: " + x[2] + "\t");
                    Console.Write("unit size: " + x[3] + "\t");
                    Console.WriteLine("description: " + x[4] + "\t");
                }
                Console.WriteLine("End of file");
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

        public static string GrabProduce(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string pick = "";
            StreamReader sr = null;

            sr = new StreamReader("Produce.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

                }
            }
            return pick;
        }

        public static int ProduceCount()
        {
            ArrayList Products = new ArrayList();

            StreamReader sr = null;

            int count = 0;
            try
            {
                sr = new StreamReader("Produce.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string[] x = line.Split('\t');

                    Products.Add(x);

                    count++;

                }
                Console.WriteLine("End of file");
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
            return count;
        }

        public static void Produce()
        {
            ArrayList Products = new ArrayList();

            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Produce.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string[] x = line.Split('\t');

                    Products.Add(x);

                    /*
                    if (line == null)
                    {
                        Console.WriteLine("End of file");
                        return;
                    }
                    */
                    //Console.WriteLine("read: " + line);
                    Console.Write("item: " + x[0] + "\t");
                    Console.Write("price: " + x[1] + "\t");
                    Console.Write("category: " + x[2] + "\t");
                    Console.Write("unit size: " + x[3] + "\t");
                    Console.WriteLine("description: " + x[4] + "\t");
                }
                Console.WriteLine("End of file");
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

        public static string GrabMeats(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string pick = "";
            StreamReader sr = null;

            sr = new StreamReader("Meats.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');

                Products.Add(z);
                a++;
                if (a == x)
                {
                    pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

                }
            }
            return pick;
        }

        public static int MeatsCount()
        {
            ArrayList Products = new ArrayList();

            StreamReader sr = null;

            int count = 0;
            try
            {
                sr = new StreamReader("Meats.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string[] x = line.Split('\t');

                    Products.Add(x);

                    count++;

                }
                Console.WriteLine("End of file");
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
            return count;
        }

        public static void Meats()
        {
            ArrayList Products = new ArrayList();

            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Meats.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string[] x = line.Split('\t');

                    Products.Add(x);

                    /*
                    if (line == null)
                    {
                        Console.WriteLine("End of file");
                        return;
                    }
                    */
                    //Console.WriteLine("read: " + line);
                    Console.Write("item: " + x[0] + "\t");
                    Console.Write("price: " + x[1] + "\t");
                    Console.Write("category: " + x[2] + "\t");
                    Console.Write("unit size: " + x[3] + "\t");
                    Console.WriteLine("description: " + x[4] + "\t");
                }
                Console.WriteLine("End of file");
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

        public static string GrabDairy(int x)
        {
            ArrayList Products = new ArrayList();

            int a = 0;
            string pick = "";
            StreamReader sr = null;
            
            sr = new StreamReader("Dairy.txt");

            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();

                string[] z = line.Split('\t');
                
                Products.Add(z);
                a++;
                if(a == x)
                {
                    pick = ("item: " + z[0] + "\t" + "price: " + z[1] + "\t" + "category: " + z[2] + "\t" + "unit size: " + z[3] + "\t" + "description: " + z[4]);

                }
            }
            return pick;
        }

        public static int DairyCount()
        {
            ArrayList Products = new ArrayList();

            StreamReader sr = null;

            int count = 0;
            try
            {
                sr = new StreamReader("Dairy.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string[] x = line.Split('\t');

                    Products.Add(x);

                    count++;

                }
                Console.WriteLine("End of file");
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
            return count;
        }

        public static void Dairy()
        {
            ArrayList Products = new ArrayList();

            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Dairy.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

                    string[] x = line.Split('\t');

                    Products.Add(x);

                    /*
                    if (line == null)
                    {
                        Console.WriteLine("End of file");
                        return;
                    }
                    */
                    //Console.WriteLine("read: " + line);
                    Console.Write("item: " + x[0] + "\t");
                    Console.Write("price: " + x[1] + "\t");
                    Console.Write("category: " + x[2] + "\t");
                    Console.Write("unit size: " + x[3] + "\t");
                    Console.WriteLine("description: " + x[4] + "\t");

                }
                Console.WriteLine("End of file");
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
    }
}
