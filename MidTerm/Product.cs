using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace MidTerm
{
    class Product
    {

		public static string Dairy()
        {
			//List<Product> ReadFile(string filename)
            ArrayList Products = new ArrayList();

            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Dairy.txt");

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();

					string x = line.Split('\t');

                    //Product p = new Product(line, "", "", 0);
                    //Products.Add(p);

                    /*
                    if (line == null)
                    {
                        Console.WriteLine("End of file");
                        return;
                    }
                    */

                    Console.WriteLine("read: " + line);
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

            return Products;
        }
    }
}
