using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n, r, sum = 0, temp;


            Console.WriteLine("Enter any number :");
            n = int.Parse(Console.ReadLine());

            temp = n;

            while (n > 0)
            {
                r = n % 10;            // 121 % 10 = 1 , 12%10= 2 , 1%10 = 0
                sum = (sum * 10) + r;  // (0*10)+1 = 1 , (1*10) + 1 = 11, (11*10) + 1 = 121
                n = n / 10;            // 121 / 10 = 12 , 12/10 = 1 , 1/10 = 0

            }


            if (temp == sum)
            {
                Console.WriteLine("The number is palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not palindrome.");
            }

            Console.ReadLine();
        }
    }
}
