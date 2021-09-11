using System;

namespace Assignment1
{
    public class TShirt : IPurchasable, ITaxable, IShippable
    {
        public double Price { get; set; }
        public string Size { get; set; }
        public double TaxRate { get; set; }
        public double ShippingRate { get; set; }

        public void Purchase()
        {
            Console.WriteLine($"Purchasing TShirt {Size} for {Price.ToString("C0")}.");
        }

        public double Ship()
        {
            Console.WriteLine($"\tShipping Rate: {ShippingRate.ToString("C")}");
            return ShippingRate;
        }

        public double Tax()
        {
            var tax = Price * TaxRate;
            Console.WriteLine($"\tTaxRate: {TaxRate} = {tax}");
            return tax;
        }
        public double SubTotal()
        {
            return Price;
        }
    }

}





