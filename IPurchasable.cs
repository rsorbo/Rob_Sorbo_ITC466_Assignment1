namespace Assignment1
{
    interface IPurchasable
    {
        double Price { get; set; }

        double SubTotal();

        void Purchase();
    }

}





