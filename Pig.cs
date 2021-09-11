using System;

namespace Assignment1
{
    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound() //add override
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
}


