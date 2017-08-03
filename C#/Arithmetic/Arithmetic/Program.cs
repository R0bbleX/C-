using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            char sign = ' ';
            double result;

            Console.WriteLine("Enter a number");
            first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a mathematical operator");
            sign = Console.ReadKey().KeyChar;

            switch (sign)
            {
                case '+':
                    result = add(first, second);
                    Console.WriteLine(result);
                    break;
                case '-':
                    result = subtract(first, second);
                    Console.WriteLine(result);
                    break;
                case '*':
                    result = multiply(first, second);
                    Console.WriteLine(result);
                    break;
                case '/':
                    result = divide(first, second);
                    Console.WriteLine(result);
                    break;
                case '^':
                    result = power(first, second);
                    Console.WriteLine(result);
                    break; 

            }
        }
            static double add(int first, int second)
            {
                double answer = first + second;

                return answer;
            }


            static double multiply(int first, int second)
            {
                double answer = first*second;

                return answer;
            }

            static double subtract(int first, int second)
            {
                double answer = first - second;

                return answer;
            }

            static double divide(int first, int second)
            {
                double answer = first/second;

                return answer;
            }
            static double power(int first, int second)
            {
                double answer = Math.Pow(first,second);

                return answer;
            }











    }
}
