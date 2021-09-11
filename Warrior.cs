using System;

namespace Assignment1
{
    partial class Program
    {
        internal class Warrior : Player
        {
            public int Bonus { get; set; }


            public override void Attack()
            {
                var rand = new Random();

                Console.WriteLine($"{Name} charges for {Bonus + (rand.Next(0, Strength))} damage (includes +{Bonus} bonus)");
            }
        }


    }

}





