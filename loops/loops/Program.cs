using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c, i, num;
            Console.WriteLine("Enter the number of elements");
            num = int.Parse(Console.ReadLine());
            Console.Write(a + " " + b + " ");
            for (i = 2; i < num; i++)
            {
                c = a + b;
                Console.Write(c+" ");
                a = b;
                b = c;
            }
        }

    }
}
