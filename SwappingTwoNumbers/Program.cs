using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, temp;

            Console.WriteLine("Enter n1");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter n2");
            n2 = int.Parse(Console.ReadLine());

            temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine("First number " + n1);
            Console.WriteLine("Second number" + n2);

            Console.ReadLine();
        }
    }
}
