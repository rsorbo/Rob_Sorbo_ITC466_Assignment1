using System;
using System.Collections.Generic; //added to help work with the Lists

namespace Assignment1
{
    partial class Program
    {

        static void Main(string[] args)
        {
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");

        }
        public static string DisplayMenu()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Rob Sorbo");
            Console.WriteLine("ITC 466: Homework Assignment 1");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            //Console.WriteLine("Hit [4] to run Exercise 4.");
            //Console.WriteLine("Hit [5] to run Exercise 5.");

            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;


        }
        private static bool Run(string exeArg)

        {
            switch (exeArg.ToLower())
            {

                case "1":
                    DoExe1();
                    return true;

                case "2":
                    DoExe2();
                    return true;

                case "3":
                    DoExe3();
                    return true;

                //case "4":
                //    DoExe4();
                //    return true;

                //case "5":
                //    DoExe5();
                //    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }

        private static void DoExe1()
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }

        private static void DoExe2()
        {
            var player = new Player() { Name = "Bob", Strength = 20 };
            var warrior = new Warrior() { Name = "Baltek", Strength = 100, Bonus = 10 };
            var wizard = new Wizard() { Name = "Pentagorn", Strength = 50, Energy = 50 };

            var players = new List<Player>();
            players.Add(player);
            players.Add(warrior);
            players.Add(wizard);

            DoBattle(players);

            Console.ReadLine();
        }

        private static void DoExe3()
        {
            var appointment = new Appointment()
            {
                Name = "Bob",
                StartDateTime = DateTime.Now.AddHours(1),
                EndDateTime = DateTime.Now.AddHours(2),
                Price = 100D
            };

            var book = new Book()
            {
                Title = "How to Implement Interfaces",
                Price = 50D,
                TaxRate = 0.0825D,
                ShippingRate = 5D
            };

            var snack = new Snack()
            {
                Price = 2D
            };

            var tshirt = new TShirt()
            {
                Size = "2X",
                Price = 25D,
                TaxRate = 0.0625D,
                ShippingRate = 2D
            };

            var items = new List<IPurchasable>();
            items.Add(appointment);
            items.Add(book);
            items.Add(snack);
            items.Add(tshirt);

            double subTotal = CalculateSubTotal(items);


            var taxableItems = new List<ITaxable>();
            foreach (var item in items)
            {
                if (item is ITaxable)
                {
                    taxableItems.Add(item as ITaxable);
                }
            }
            var taxAmount = CalculateTax(taxableItems);
            Console.WriteLine($"Total tax amount: {taxAmount.ToString("C")}");
            Console.WriteLine();

            var shipItems = new List<IShippable>();
            shipItems.Add(book);
            shipItems.Add(tshirt);


            var shipAmount = CalculateShipping(shipItems);
            Console.WriteLine($"Total shipping amount: {shipAmount.ToString("C")}");
            Console.WriteLine();


            CompleteTransaction(items);



            double grandTotal = taxAmount + shipAmount + subTotal;
            Console.WriteLine($"Grand Total : {grandTotal.ToString("C")}");

            Console.ReadLine();
        }

        private static void DoExe4()
        {
            // Add code for Exercise 4 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            throw new NotImplementedException();
        }

        private static void DoExe5()
        {
            // Add code for Exercise 5 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            throw new NotImplementedException();
        }


        //List<> : https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-5.0 
        public static void DoBattle(List<Player> players)
        {


            foreach (Player player in players) //replaced 'var' with 'Player
            {
                player.Attack();


                Console.WriteLine("");
            }
        }


        private static double CalculateSubTotal(List<IPurchasable> items)
        {

            double subTotal = 0;

            foreach (var item in items)
            {
                subTotal += item.SubTotal();
            }

            return subTotal;
        }

        static double CalculateTax(List<ITaxable> items)
        {
            double tax = 0D;

            foreach (var item in items)
            {
                tax += item.Tax();
            }

            return tax;

        }

        static double CalculateShipping(List<IShippable> items)
        {
            double shipping = 0D;

            foreach (var item in items)
            {
                shipping += item.Ship();
            }

            return shipping;
        }

        static void CompleteTransaction(List<IPurchasable> items)
        {

            items.ForEach(p => p.Purchase());


            Console.WriteLine("==========");

        }


    }

}





