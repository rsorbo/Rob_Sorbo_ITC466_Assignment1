using System;

namespace Assignment1
{
    partial class Program
    {
        internal class Player
        {
            public string Name { get; set; }
            public int Strength { get; set; }

            public virtual void Attack()
            {
                //random number https://docs.microsoft.com/en-us/dotnet/api/system.random.next?view=net-5.0
                var rand = new Random();

                Console.WriteLine($"{Name} attacked for {rand.Next(0, Strength)} damage");
            }

        }


    }

}





