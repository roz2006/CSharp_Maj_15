using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Udskrive(1);
        }

        static void Udskrive(int a)
        {
            if (a > 10)
            { return;} 
            else
            {
                Console.WriteLine(a);
                Udskrive(++a);
            }
        }
    }
}
