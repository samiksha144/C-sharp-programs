using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 1, k, number;

            Console.WriteLine("Enter number of elements");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine(i);
            Console.WriteLine(j);



            for (k = 2; k <= number; k++)
            {
                k = i + j;
                Console.WriteLine(k);

                i = j;
                j = k;
            }

            Console.ReadLine();
        }
    }
}
