using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookList
{
    class Program
    {
        static void Main(string[] args)
        {

            
            List<string> books = new List<string>()
            { "Harry Potter", "Lord of the rings", "Hunger games", "Wounded knee"};

            string addBook = "";
            bool exit = false;
            string removeBook = "";

            

            do
            {
                Console.WriteLine("Would you like to: \n add a book (A)? \n Remove a book (R) \n List all the books (L) \n ");
                char response = Convert.ToChar(Console.ReadLine().ToUpper());

                if (response == 'A')

                {
                    Console.WriteLine("Which book would you like to add?");
                    addBook = Console.ReadLine();
                    books.Add(addBook);
                    Console.WriteLine(addBook + " has been added to the list, would you like to add/remove another? Press A to add another, R to remove, otherwise press N. ");
                    response = Convert.ToChar(Console.ReadLine().ToUpper());
                }


                if (response == 'R')
                {
                    Console.WriteLine("Which book would you like to remove?");
                    removeBook = Console.ReadLine();
                    books.Remove(removeBook);
                    Console.WriteLine(removeBook + " has been removed from the list, would you like to remove/add another? Press A to add another, R to remove, otherwise press N. ");

                }

                if (response == 'N')

                {
                    exit = true;

                }

            }
            while (exit == false);

            foreach (string title in books)

            {
                Console.WriteLine(title);
            }

        }
    }
}

