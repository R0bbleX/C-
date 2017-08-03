using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chooseFruit
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            string moarFruit = "yes";

            do
            {
                Console.WriteLine("What's your favourite fruit?");
                answer = (System.Console.ReadLine());

                switch (answer)
                {
                    case "banana":
                        Console.WriteLine("Good for potassium");
                        break;
                    case "watermelon":
                        Console.WriteLine("Tasty");
                        break;
                    case "grapes":
                    case "apples":
                        Console.WriteLine("I'm allergic to " + answer);
                        break;
                    default:
                        Console.WriteLine("Do you want to choose another better fruit? (yes) or give up? (no)");
                        moarFruit = Console.ReadLine().ToLower();
                        break;

                }

            } while (moarFruit == "yes");
            

        }
    }
}
