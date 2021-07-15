using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string userColor;
            if (args.Length == 0)
            {
                Console.WriteLine("There are no command line arguments");
            }
            else
            {
                Console.WriteLine("Please enter your name...");
                var userName = Console.ReadLine();
                Console.WriteLine($"{userName} welcome to the app!");
                Console.WriteLine("Please choose a greeting:");
                for (var i = 0; i < args.Length; i++)
                {
                    Console.Write(args[i] + Environment.NewLine);
                }
                var userResponse = Console.ReadLine();
                switch (userResponse.ToLower())
                {
                    case "southern":
                        Console.WriteLine("Howdy Y'all!");
                            break;
                    case "british":
                        Console.WriteLine("Good evening mate!");
                        break;
                    case "crazy":
                        Console.WriteLine("WOOOOOOOOOOOOOOOO!!!!!!!!!!");
                        break;
                    default:
                        Console.WriteLine("That was not a valid greeting you asshole...");
                        break;
                }
            }
            Console.WriteLine("Please enter your favorite color!");
            userColor = Console.ReadLine();
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            Console.WriteLine("Would you like a random animal with your favorite color?");
            Console.WriteLine("y/n");
            var enteredKey = Console.ReadKey();
            if (enteredKey.Key.ToString() != "N")
            {
                Random rnd = new Random();
                var randomIndex = rnd.Next(0, 3);
                Console.WriteLine($"I have randomly chosen a {userColor} {animals[randomIndex]}");
            }
            foreach (var animal in animals)
            {
                if (animal.Length > 5)
                {
                    Console.WriteLine(animal);
                }
                
            }
            Console.ReadKey();
        }
    }
}
