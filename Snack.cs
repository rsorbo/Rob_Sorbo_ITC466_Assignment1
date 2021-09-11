using System;

namespace Assignment1
{
    public class Snack : IPurchasable
    {
        public double Price { get; set; }

        public void Purchase()
        {
            Console.WriteLine($"Purchasing a snack for {Price.ToString("C0")}.");
        }
        public double SubTotal()
        {
            return Price;
        }
    }

}





