using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("There are no command line arguments");
            }
            else
            {
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

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

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
