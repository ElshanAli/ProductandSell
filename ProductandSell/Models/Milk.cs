using System;
using System.Collections.Generic;
using System.Text;

namespace ProductandSell.Models
{
    class Milk : Product
    {
        public double Volume { get; set; }
        public double FatRate { get; set; }
        public Milk(string name, double price, double volume, double fatRate,byte buy) : base(name, price,buy)
        {
            Volume = volume;
            FatRate = fatRate;
            Console.WriteLine(" Enter the fatrate");
            FatRate = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine(" How many products do you want? ");
            Buy = Convert.ToByte(Console.ReadLine());
        }
        public Milk()
        {
            
        }
        public override void Sell()
        {
            if (Count >= 1)
            {              
                TotalIncome += Price*Buy;
                TotalSaled+=Buy;
                Count -= Buy;
                Console.WriteLine($" Product Name: {Name}\n Price: {Price}\n Stock Number: {Count}");
                Console.WriteLine($" Total Sales : {TotalSaled}" + $" \n Gross income : {TotalIncome}");
            }
            else
            {
                Console.WriteLine(" There is no product" );
            }
            if (FatRate > 0 && FatRate <= 3)
            {
                Console.WriteLine($" The fatrate content of this product: {FatRate}");
            }          
            else
            {
                Console.WriteLine($" Not proper fatrate {FatRate}");
            }
        }
    }
}
