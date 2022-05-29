using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDecimalToBinary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n, binaryValue = 0, decimalValue = 1, baseValue = 1, remainder;

            Console.WriteLine("Enter any binary number");
            n = int.Parse(Console.ReadLine());

            binaryValue = n;

            while (n > 0)
            {
                remainder = n % 10;
                decimalValue = decimalValue + remainder * baseValue;
                n = n / 10;
                baseValue = baseValue * 2;
            }

            Console.WriteLine("The binary value is :" + binaryValue);
            Console.WriteLine("The decimal value is :" + decimalValue);

            Console.ReadLine();
        }
    }
}
