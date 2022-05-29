using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter any number : ");
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }

            else
            {
                Console.WriteLine("The number is odd");
            }

            Console.ReadLine();

        }
    }
}
