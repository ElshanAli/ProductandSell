using ProductandSell.Models;
using System;

namespace ProductandSell
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Milk organic = new Milk(" Organic Valley", 3.5, 1, 3,100);           
            organic.Sell();
            Milk califia = new Milk(" Califia Farms", 2, 1, 2,100);
            califia.Sell();
                       
        }
    }
}
