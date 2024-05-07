using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 3 and 5 = FizzBuzz
             * 3 = Fizz
             * 5 = Buzz
             */

            Console.Write("Enter a number : ");
            int numInput = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= numInput; i++)
            {
                if(i%3 == 0 && i%5 == 0)
                {
                    Console.WriteLine($"Fizzbuzz -> {i}");
                }else if(i%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }else if(i%5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
