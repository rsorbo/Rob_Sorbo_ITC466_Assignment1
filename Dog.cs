using System;

namespace Assignment1
{
    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()  //add override
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}


