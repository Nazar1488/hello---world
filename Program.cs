using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace product_project_practic
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnetcion sql = new SqlConnection("path");
            List<Product> products = new List<Product>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.Read from file");
                Console.WriteLine("2.Sort by name");
                Console.WriteLine("3.Sort by price");
                Console.WriteLine("4.Sort by number");
                Console.WriteLine("5.Find by name");
                Console.WriteLine("6.Show all products");
                Console.WriteLine("7.Show all products with sum price");
                Console.WriteLine("8.Exit");
                string key= Console.ReadLine();
                if (key == "1")
                {
                    products.Clear();
                    StreamReader fs = new StreamReader(@"..\\..\\text.txt");
                    while (!fs.EndOfStream)
                    {
                        string temp1 = fs.ReadLine();
                        if (temp1 != null && temp1 !="")
                        {
                            string[] res = temp1.Split();
                            products.Add(new Product(res[0], Convert.ToInt32(res[1]), Convert.ToInt32(res[2])));
                        }
                    }
                    foreach (Product p in products)
                    {
                        Console.WriteLine(p);
                    }
                }
                if(key=="2")
                {
                    products.Sort( new ProductNameComperer());
                    foreach (Product p in products)
                    {
                        Console.WriteLine(p);
                    }
                }
                if (key == "3")
                {
                    products.Sort(new ProductPriceComperer());
                    foreach (Product p in products)
                    {
                        Console.WriteLine(p);
                    }
                }
                if (key == "4")
                {
                    products.Sort(new ProductNumberComperer());
                    foreach (Product p in products)
                    {
                        Console.WriteLine(p);
                    }
                }
                if(key =="5")
                {
                    Console.Write("name=");
                    string val = Console.ReadLine();
                    bool flag = false;
                    foreach(Product p in products)
                    {
                        if(p.Name == val)
                        {
                            flag = true;
                            Console.WriteLine(p);
                        }
                    }
                    if(flag==false)
                    {
                        Console.WriteLine("Products with this name are not!");
                    }
                }
                if(key=="6")
                {
                    foreach(Product p in products)
                    {
                        Console.WriteLine(p);
                    }
                }
                if(key=="7")
                {
                    foreach(Product p in products)
                    {
                        Console.WriteLine(p +"\t"+ "sum_price: " + p.sum_price());
                    }
                }
                if(key=="8")
                {
                    break;
                }

                Console.ReadKey();
            }
        }
    }
}
