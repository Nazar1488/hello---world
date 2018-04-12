using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_project_practic
{
    class Product 
    {
        private string name;
        private int price;
        private int number;
        public Product(string _name, int _price, int _number)
        {
            name = _name;
            Price = _price;
            Number = _number;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
           private  set
            {
                if(value<0)
                {
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }
        }
        public int Number
        {
            get
            {
                return number;
            }
            private set
            {
                if(value<0)
                {
                    number = 0;
                }
                else
                {
                    number = value;
                }
            }
        }
        public int sum_price()
        {
            return price * number;
        }
       
        public override string ToString()
        {
            return "name: "+ name + "\t"+"price: " + price+ "\t"+ "number: " + "\t" + number;
        }


    }
    class ProductNameComperer : IComparer<Product>
    {
        public int Compare(Product first,Product second)
        {
            return string.Compare(first.Name ,second.Name);
             
        }
    }
    class ProductPriceComperer : IComparer<Product>
    {
        public int Compare(Product first, Product second)
        {
            if (first.Price > second.Price) return 1;
            else if (first.Price < second.Price) return -1;
            else return 0;


        }
    }
    class ProductNumberComperer : IComparer<Product>
    {
        public int Compare(Product first, Product second)
        {
            if (first.Number > second.Number) return 1;
            else if (first.Number < second.Number) return -1;
            else return 0;


        }
    }
}


