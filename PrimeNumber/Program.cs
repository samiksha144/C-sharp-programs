using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, n, flag = 0;
            Console.WriteLine("Enter the number :");
            n = int.Parse(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("Invalid number");
            }

            else if (n == 1)
            {
                Console.WriteLine("The number is neither prime nor composite ");
            }

            else
            {
                for (i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("The number is not prime");
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                    Console.WriteLine("The number is prime");



            }

            Console.ReadLine();



        }
    }
}
