using System;

namespace Assignment1
{
    partial class Program
    {
        internal class Wizard : Player
        {
            public int Energy { get; set; }  // add these on the other properties



            public override void Attack()
            {
                var rand = new Random();

                Console.WriteLine($"{Name} attacked for {rand.Next(0, Strength)} damage");

                var rand2 = new Random();
                int deplete = rand2.Next(0, 10);

                Console.WriteLine($"\tWizard {Name} depleted {deplete} energy.");
                Energy = Energy - deplete;
            }

        }


    }

}





