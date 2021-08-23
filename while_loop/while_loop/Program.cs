using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            System.Console.WriteLine("Number from 1 to 10");
            while(a<=10)
            {
                System.Console.WriteLine("print " + a);
                a++;
            }
        }
    }
}
