using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n, reverse = 0, r;

            Console.WriteLine("Enter any number");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                r = n % 10; //2, 43%10=3, 4%10 = 4
                reverse = reverse * 10 + r; //0*10+2 = 2, 2*10+3 = 23, 23*10+4= 234
                n = n / 10; // 432/10 = 43, 43/10=4, 4/10 = 0
            }

            Console.WriteLine("The reversed number is : " + reverse);
            Console.ReadLine();
        }
    }
}
