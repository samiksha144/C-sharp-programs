using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n1, n2, add, sub, mul, div, mod;

            Console.WriteLine("Enter first number :");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number :");
            n2 = int.Parse(Console.ReadLine());

            add = n1 + n2;
            sub = n1 - n2;
            mul = n1 * n2;
            div = n1 / n2;
            mod = n1 % n2;

            Console.WriteLine("Ans is : " + add);
            Console.WriteLine("Ans is : " + sub);
            Console.WriteLine("Ans is : " + mul);
            Console.WriteLine("Ans is : " + div);
            Console.WriteLine("Ans is : " + mod);

            Console.ReadLine();
        }
    }
}
