using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n, r, temp, sum = 0;
            Console.WriteLine("Enter any number :");
            n = int.Parse(Console.ReadLine());

            temp = n;

            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("the number is Armstrong");
            }

            else
            {
                Console.WriteLine("The number is not Armstrong");
            }

            Console.ReadLine();
        }
    }
}
