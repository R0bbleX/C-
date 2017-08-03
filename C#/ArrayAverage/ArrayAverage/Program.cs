using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[5, 5];
            Random rdn = new Random();

            int[] rowTotal = new int[5];
            int[] colTotal = new int[5];
            int overallTotal = 0;

            //Loop to sum all numbers

            for (int i = 0; i < numbers.GetLength(0); i++)

                for (int j = 0; j < numbers.GetLength(1); j++)
                {   
                    //Fill array with random numbers
                    numbers[i, j] = rdn.Next(1, 11);

                    //Display array
                    Console.Write(numbers[i, j] + "\t");


                    //Calculate totals
                    rowTotal[i] += numbers[i, j];
                    colTotal[j] += numbers[i, j];
                    overallTotal += numbers[i, j];

                }

            //Display row/column totals

            Console.WriteLine();

            for (int i = 0; i < rowTotal.Length; i++)
            {
                Console.WriteLine("The total of row " + (i + 1) + "is " + rowTotal[i]);

            }
            for (int i = 0; i < colTotal.Length; i++)
            {
                Console.WriteLine("The total of column " + (i+1) + "is " + colTotal[i]);
    
            }

            //Display total
            Console.WriteLine("The overall total is: " + overallTotal);
        }





    }

        

}
