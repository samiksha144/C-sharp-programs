using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, fact = 1, number;

            Console.Write("Enter any number : ");
            number = int.Parse(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact);

            Console.ReadLine();
        }
    }
}
