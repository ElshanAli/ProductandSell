using System;
using System.Collections.Generic;
using System.Text;

namespace ProductandSell
{
   public abstract class Product
    {
        public string Name;
        public double Price;
        public static byte Buy;
        public static int Count = 100;
        public static double TotalIncome=0;
        public static int TotalSaled = 0;

        public Product(string name, double price,byte buy)
        {
            Name = name;
            Price = price;
            Buy = buy;
        }
        public Product()
        {
        }
        public abstract void Sell();      
    }
}
