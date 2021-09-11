using System;

namespace Assignment1
{
    public class Appointment : IPurchasable
    {
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double Price { get; set; }

        public void Purchase()
        {
            Console.WriteLine($"Payment for Appointment for {Name} from {StartDateTime} to {EndDateTime} for {Price.ToString("C0")}.");
        }

        public double SubTotal()
        {
            return Price;
        }
    }

}





