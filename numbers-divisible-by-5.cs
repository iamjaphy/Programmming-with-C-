using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Enter the first nunmber: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i < b; i++)
            {
                if (i % 5 == 0) count++;
            }

            Console.WriteLine("From {0} to {1}, there are {2} numbers found that are divisible by 5.", a, b, count);
            Console.ReadKey();
        }
    }
}
